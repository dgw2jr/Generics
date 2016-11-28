using Domain.Interfaces;

namespace Infrastructure.Data
{
    public sealed class UnitOfWork<TModel, TKey> : IUnitOfWork<TModel, TKey> where TModel : class
    {
        private readonly GenericContext<TModel> _context;

        public UnitOfWork(IRepository<TModel, TKey> repository, GenericContext<TModel> context)
        {
            Repository = repository;
            _context = context;
        }

        public IRepository<TModel, TKey> Repository { get; }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}