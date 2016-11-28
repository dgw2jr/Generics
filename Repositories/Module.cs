using Autofac;

namespace Infrastructure.Data
{
    public sealed class RepositoriesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Repository<,>)).AsImplementedInterfaces();
            builder.RegisterGeneric(typeof(GenericContext<>)).AsSelf().InstancePerRequest();
            builder.RegisterGeneric(typeof(UnitOfWork<,>)).AsImplementedInterfaces();
        }
    }
}
