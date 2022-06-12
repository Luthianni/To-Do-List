using PraHoje.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PraHoje.Services
{
    public interface ITarefasListaService
    {
        Task<TarefasListaDTO> AdicionarTarefa(string descricao);
        Task<IEnumerable<TarefasListaDTO>> GetAllAsync();
        Task GetByIdAsync(Guid Id);
        Task UpdateAsync(Guid id);
        Task<bool> Delete(Guid Id);
    }
}
