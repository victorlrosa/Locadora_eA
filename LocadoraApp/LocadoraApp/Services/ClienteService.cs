using LocadoraApp.Data;
using LocadoraApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraApp.Services
{
    public class ClienteService
    {
        private readonly LocadoraAppContext _context;

        public ClienteService(LocadoraAppContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> FindAllAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task InsertAsync(Cliente obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Cliente> FindByIdAsync(int id)
        {
            return await _context.Clientes.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Clientes.FindAsync(id);
                _context.Clientes.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new DbUpdateException("Erro ao remover um cliente!" + e.Message);
            }
        }

        public async Task UpdateAsync(Cliente obj)
        {
            var hasAny = await _context.Clientes.AnyAsync(x => x.Id == obj.Id);

            if (!hasAny)
                throw new Exception("Id não encontrado!");

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {

                throw new DbUpdateConcurrencyException("Falha ao atualizar o cliente." + e.Message);
            }
        }

    }
}
