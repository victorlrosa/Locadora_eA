using LocadoraApp.Data;
using LocadoraApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraApp.Services
{
    public class FilmeService
    {
        private readonly LocadoraAppContext _context;

        public FilmeService(LocadoraAppContext context)
        {
            _context = context;
        }

        public async Task<List<Filme>> FindAllAsync()
        {
            return await _context.Filmes.ToListAsync();
        }

        public async Task InsertAsync(Filme obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Filme> FindByIdAsync(int id)
        {
            return await _context.Filmes.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Filmes.FindAsync(id);
                _context.Filmes.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new DbUpdateException("Erro ao remover um filme!" + e.Message);
            }
        }

        public async Task UpdateAsync(Filme obj)
        {
            var hasAny = await _context.Filmes.AnyAsync(x => x.Id == obj.Id);

            if (!hasAny)
                throw new Exception("Id não encontrado!");

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {

                throw new DbUpdateConcurrencyException("Falha ao atualizar o filme." + e.Message);
            }
        }
    }
}
