using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IRepository<TModel, TKey>
    {
        IEnumerable<TModel> List { get; }
        void Add(TModel entity);
        void Delete(TModel entity);
        void Update(TModel entity);
        TModel FindById(TKey Id);
    }
}