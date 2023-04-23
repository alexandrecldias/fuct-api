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
    public class MinerioRepository : BaseRepository<Minerio>, IMinerioRepository
    {
        public MinerioRepository(ServiceContext context) : base(context)
        {
        }

    }
}
