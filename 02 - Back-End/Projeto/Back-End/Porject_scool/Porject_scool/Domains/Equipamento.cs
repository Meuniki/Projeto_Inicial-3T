using System;
using System.Collections.Generic;

#nullable disable

namespace Porject_scool.Domains
{
    public partial class Equipamento
    {
        public Equipamento()
        {
            Entrada = new HashSet<Entrada>();
        }

        public int IdEquipamento { get; set; }
        public string Marca { get; set; }
        public string TipoEquipamento { get; set; }
        public string NumSerie { get; set; }
        public string Descricao { get; set; }
        public string NumPatrimonio { get; set; }
        public bool Ativo { get; set; }

        public virtual ICollection<Entrada> Entrada { get; set; }
    }
}
