using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options)
        {
        }

        public DbSet<Minerio> Mineiro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MinerioMap());
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            var result = base.SaveChanges(acceptAllChangesOnSuccess);
            return result;
        }

        public void DetachAllEntities()
        {
            var changedEntriesCopy = ChangeTracker.Entries();

            foreach (var entry in changedEntriesCopy)
                entry.State = EntityState.Detached;
        }
    }
}
