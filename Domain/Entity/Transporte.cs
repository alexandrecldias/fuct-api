using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Transporte : EntityBase
    {
        Cargueiro cargueiro;
        DateTime dataHoraSaida;
        DateTime dataHoraRetorno;
        int quantidadeMinerais;
        decimal valorCarga;
        Minerio minerio;

    }
}
