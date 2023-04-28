using Domain.Entity;
using Domain.Repository;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class TransporteRespository : BaseRepository<Transporte>, ITransporteRepository
    {
        public TransporteRespository(ServiceContext context) : base(context)
        {
        }
    }
}
