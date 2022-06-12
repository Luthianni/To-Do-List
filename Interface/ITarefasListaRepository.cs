using PraHoje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraHoje.Interface
{
    public interface ITarefasListaRepository
    {
        Task<IEnumerable<TarefasListaVM>> ObterTodos();

        Task Adicionar(TarefasListaVM entidade);
        Task Update(TarefasListaVM tarefasListaVM);
        Task<bool> Delete(Guid Id);

        Task<TarefasListaVM> Get(Guid id);
    }
}
