namespace Domain.Interfaces
{
    public interface IUnitOfWork<TModel, TKey>
    {
        IRepository<TModel, TKey> Repository { get; }
        int SaveChanges();
    }
}