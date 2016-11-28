namespace Services.Interfaces
{
    public interface IUpdateCommand<TModel>
    {
        void Execute(TModel value);
    }
}