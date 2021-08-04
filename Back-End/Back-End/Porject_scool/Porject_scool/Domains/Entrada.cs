using System;
using System.Collections.Generic;

#nullable disable

namespace Porject_scool.Domains
{
    public partial class Entrada
    {
        public int IdEntrada { get; set; }
        public int? IdSala { get; set; }
        public int? IdEquipamento { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }

        public virtual Equipamento IdEquipamentoNavigation { get; set; }
        public virtual Sala IdSalaNavigation { get; set; }
    }
}
