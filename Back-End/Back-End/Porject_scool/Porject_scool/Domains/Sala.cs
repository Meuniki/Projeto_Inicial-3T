using System;
using System.Collections.Generic;

#nullable disable

namespace Porject_scool.Domains
{
    public partial class Sala
    {
        public Sala()
        {
            Entrada = new HashSet<Entrada>();
        }

        public int IdSala { get; set; }
        public string Instituicao { get; set; }
        public string Andar { get; set; }
        public string Nome { get; set; }
        public double MetragemSala { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }

        public virtual ICollection<Entrada> Entrada { get; set; }
    }
}
