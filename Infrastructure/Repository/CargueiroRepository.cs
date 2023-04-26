using Domain.Entity;
using Domain.Repository;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class CargueiroRepository : BaseRepository<Cargueiro>, ICargueiroRepository
    {
        public CargueiroRepository(ServiceContext context) : base(context)
        {
        }

        public Cargueiro BuscarCargueirosComMinerioAssociado(int idCargueiro)
        {
            return DbSet.Include(x => x.Minerio).AsQueryable().AsNoTracking().FirstOrDefault(y => y.Id == idCargueiro);
        }
    }
}
