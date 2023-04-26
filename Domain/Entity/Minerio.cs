using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Minerio : EntityBase
    {
        public char tipoMineral { get; set; }
        public string caracteristica { get; set; }
        public decimal preco { get; set; }
        public int peso { get; set; }
        public virtual Cargueiro Cargueiro { get; set; }
    }
}
