namespace Services.Interfaces
{
    public interface IDeleteCommand<TKey>
    {
        void Execute(TKey id);
    }
}