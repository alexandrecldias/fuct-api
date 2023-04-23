using Domain;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : EntityBase
    {
        protected DbSet<TEntity> DbSet;
        public readonly ServiceContext _context;

        public BaseRepository(ServiceContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }

        public void Adicionar(TEntity entity)
        {
            entity.LgUsuario = "teste";
            entity.DtAlteracao = DateTime.Now;
            DbSet.Add(entity);
        }

        public TEntity BuscarPorId(int id)
        {
            return DbSet.Find(id);
        }

        public ICollection<TEntity> BuscarTodos()
        {
            return DbSet.ToList();
        }

        public ICollection<TEntity> BuscarTodosPaginado(int pagina, int quantidadePorPagina)
        {
            return DbSet.Skip(pagina).Take(pagina).ToList();
        }


        public ICollection<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            var entityDB = DbSet.Find(entity.Id);
            _context.Entry(entityDB).CurrentValues.SetValues(entity);
            entity.LgUsuario = "teste";
            entity.DtAlteracao = DateTime.Now;
            DbSet.Update(entityDB);
        }

        public void UpdateCompose(TEntity entity, object[] chaves)
        {
            throw new NotImplementedException();
        }

        public void AdicionarRange(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}
