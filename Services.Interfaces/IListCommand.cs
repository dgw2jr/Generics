using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IListCommand<TModel>
    {
        IEnumerable<TModel> Execute();
    }
}