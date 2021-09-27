using LocadoraApp.Data;
using LocadoraApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraApp.Services
{
    public class LocacaoService
    {
        private readonly LocadoraAppContext _context;

        public LocacaoService(LocadoraAppContext context)
        {
            _context = context;
        }

        public async Task<List<Locacao>> FindAllAsync()
        {
            return await _context.Locacoes.ToListAsync();
        }

        public async Task InsertAsync(Locacao obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Locacao> FindByIdAsync(int id)
        {
            return await _context.Locacoes.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Locacoes.FindAsync(id);
                _context.Locacoes.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new DbUpdateException("Erro ao remover uma locação!" + e.Message);
            }
        }

        public async Task UpdateAsync(Locacao obj)
        {
            var hasAny = await _context.Locacoes.AnyAsync(x => x.Id == obj.Id);

            if (!hasAny)
                throw new Exception("Id não encontrado!");

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {

                throw new DbUpdateConcurrencyException("Falha ao atualizar a locação." + e.Message);
            }
        }
    }
}
