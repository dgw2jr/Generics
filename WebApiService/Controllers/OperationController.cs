﻿using Domain.Entities;
using Domain.Interfaces;

namespace WebApiService.Controllers
{
    public class OperationController : BaseController<Operation, int>
    {
        public OperationController(IUnitOfWork<Operation, int> uow) : base(uow)
        {
        }
    }
}
