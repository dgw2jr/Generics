using Domain.Entities;
using Domain.Interfaces;

namespace WebApiService.Controllers
{
    public class CustomerController : BaseController<Customer, int>
    {
        public CustomerController(IUnitOfWork<Customer, int> uow) : base(uow)
        {
        }
    }
}