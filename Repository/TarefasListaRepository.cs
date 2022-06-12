using Microsoft.EntityFrameworkCore;
using PraHoje.Context;
using PraHoje.Interface;
using PraHoje.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PraHoje.Repository
{
    public class TarefasListaRepository : ITarefasListaRepository
    {
        private readonly ConfigDB _context;

        public TarefasListaRepository(ConfigDB context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TarefasListaVM>> ObterTodos()
        {
            return await _context.TarefasListas.ToListAsync();
        }

        public async Task Adicionar(TarefasListaVM entidade)
        {
            await _context.TarefasListas.AddAsync(entidade);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Deletar(Guid Id)
        {
            var deletando = await _context.TarefasListas.SingleOrDefaultAsync(d => d.Id.Equals(Id));
            if (deletando == null)
                return false;
            _context.Remove(deletando);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task Update(TarefasListaVM tarefasListaVM)
        {
            var up = await _context.TarefasListas.SingleOrDefaultAsync(a => a.Id.Equals(tarefasListaVM.Id));
            
                    _context.Entry(up).CurrentValues.SetValues(tarefasListaVM);
            await _context.SaveChangesAsync();
           
        }

        public async Task<bool> Delete(Guid Id)
        {
            var del = await _context.TarefasListas.SingleOrDefaultAsync(d => d.Id.Equals(Id));
            if (del == null)
                return false;
            _context.Remove(del);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<TarefasListaVM> Get(Guid id)
        {
            return await _context.TarefasListas.SingleOrDefaultAsync(tar => tar.Id.Equals(id));
        }
    }
}
