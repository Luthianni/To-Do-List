using AutoMapper;
using PraHoje.Context;
using PraHoje.DTOs;
using PraHoje.Interface;
using PraHoje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraHoje.Services
{
    public class TarefasListaService : ITarefasListaService
    {
        private readonly IMapper mapper;
        private readonly ITarefasListaRepository repository;
        private readonly ConfigDB context;

        public TarefasListaService(IMapper mapper, ITarefasListaRepository repository, ConfigDB context)
        {
            this.mapper = mapper;
            this.repository = repository;
            this.context = context;
        }

        public async Task<TarefasListaDTO> AdicionarTarefa(string descricao)
        {
            var tar = new Models.TarefasListaVM
            {
                Descricao = descricao,
                DataInclusao = DateTime.Now,
                Status = Models.StatusTarefa.Nova

            };
            await context.AddAsync(tar);
            await context.SaveChangesAsync();

            return mapper.Map<TarefasListaDTO>(tar);
        }



        public async Task<IEnumerable<TarefasListaDTO>> GetAllAsync()
        {
            var anotacoes = await repository.ObterTodos();
            var anotacoesLista = mapper.Map<IEnumerable<TarefasListaDTO>>(anotacoes);
            return anotacoesLista;
        }

        public async Task UpdateAsync(Guid id)
        {
            var resp = await repository.Get(id);
            resp.DataDaFinalizacao = DateTime.Now;
            resp.Status = StatusTarefa.Concluida;

            await repository.Update(resp);
        }

        public async Task<bool> Delete(Guid Id)
        {
            return await repository.Delete(Id);
        }

        public async Task GetByIdAsync(Guid id)
        {
            var task = await context.TarefasListas.FindAsync(id);
            context.Remove(task);
            await context.SaveChangesAsync();
        }
    }
}
