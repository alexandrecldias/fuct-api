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
        public char tipoMineral;
        public string caracteristica;
        public decimal preco;
        public int peso;
    }
}
