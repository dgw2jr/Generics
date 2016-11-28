using System.Data.Entity;

namespace Infrastructure.Data
{
    public class GenericContext<TModel> : DbContext where TModel : class
    {
        public GenericContext() : base("name=Customers")
        {
        }

        public DbSet<TModel> Models { get; set; }
    }
}
