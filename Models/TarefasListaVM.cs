using PraHoje.BaseIdentity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraHoje.Models
{
    public enum StatusTarefa
    {
        Nova = 1,
        Concluida = 2
    }
    public class TarefasListaVM : IdentificacaoBase
    {
        
        public StatusTarefa Status { get; set; }
        public DateTime? DataDaFinalizacao { get; set; }
        public string Descricao { get; set; }

    }
}
