using System;
using System.Collections.Generic;
                using System.Linq;
using System.Threading.Tasks;

namespace PraHoje.BaseIdentity
{
    public class IdentificacaoBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime DataInclusao { get; set; } = DateTime.UtcNow;
    }
}
