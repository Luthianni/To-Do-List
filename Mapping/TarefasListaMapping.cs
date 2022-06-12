using AutoMapper;
using PraHoje.Models;
using PraHoje.DTOs;

namespace PraHoje.Mapping
{
    public class TarefasListaMapping : Profile
    {
        public TarefasListaMapping()
        {
            CreateMap<TarefasListaVM, TarefasListaDTO>()
                .ForMember(dto => dto.Description, config => config.MapFrom(entidade => entidade.Descricao))
                .ForMember(dto => dto.IsNew, config => config.MapFrom(entidade => entidade.Status == StatusTarefa.Nova))
                .ForMember(dto => dto.IsConcluded, config => config.MapFrom(entidade => entidade.Status == StatusTarefa.Concluida));
        }
    }
}
