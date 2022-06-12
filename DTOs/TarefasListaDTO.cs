using PraHoje.BaseIdentity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PraHoje.DTOs
{
   
    public class TarefasListaDTO 
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório", AllowEmptyStrings = false)]        
        public string Description { get; set; }
        public bool IsNew { get; set; }
        public bool IsConcluded { get; set; }

    }
}
