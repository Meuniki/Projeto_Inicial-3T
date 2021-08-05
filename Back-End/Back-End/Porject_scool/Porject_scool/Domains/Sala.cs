﻿using System;
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
        public int Andar { get; set; }
        public string Nome { get; set; }
        public double MetragemSala { get; set; }
        public int Cep { get; set; }
        public int Telefone { get; set; }

        public virtual ICollection<Entrada> Entrada { get; set; }
    }
}
