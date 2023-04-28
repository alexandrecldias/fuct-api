using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Transporte : EntityBase
    {
        public DateTime dataHoraSaida { get; set; }
        public DateTime dataHoraRetorno { get; set; }
        public float quantidadeMinerais { get; set; }
        public decimal valorCarga { get; set; }
        public char tipoMinerio { get; set; }
        public virtual Cargueiro Cargueiro { get; set; }
        public int idCargueiro { get; set; }

    }
}
