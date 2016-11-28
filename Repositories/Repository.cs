using System.Collections.Generic;
using Domain.Interfaces;
using System.Data.Entity;

namespace Infrastructure.Data
{
    public sealed class Repository<TModel, TKey> : IRepository<TModel, TKey> where TModel : class, IIdentifier<TKey>
    {
        private readonly GenericContext<TModel> _context;

        public Repository(GenericContext<TModel> context)
        {
            _context = context;
        }

        public IEnumerable<TModel> List => _context.Models;

        public void Add(TModel entity)
        {
            _context.Models.Add(entity);
        }

        public void Delete(TModel entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public TModel FindById(TKey id)
        {
            return _context.Models.Find(id);
        }

        public void Update(TModel entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}