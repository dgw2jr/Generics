namespace Domain.Interfaces
{
    public interface IIdentifier<TKey>
    {
        TKey Id { get; }
    }
}
