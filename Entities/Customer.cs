using Domain.Interfaces;

namespace Domain.Entities
{
    public class Customer : IIdentifier<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
