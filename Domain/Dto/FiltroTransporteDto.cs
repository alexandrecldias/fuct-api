using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public class FiltroTransporteDto
    {
        public DateTime dataHoraSaida { get; set; }
        public DateTime dataHoraRetorno { get; set; }
        public int classe { get; set; }
    }
}
