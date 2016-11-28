namespace Services.Interfaces
{
    public interface IFindCommand<TModel, TKey>
    {
        TModel Execute(TKey key);
    }
}