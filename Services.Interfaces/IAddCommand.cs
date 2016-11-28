namespace Services.Interfaces
{
    public interface IAddCommand<TModel>
    {
        void Execute(TModel value);
    }
}