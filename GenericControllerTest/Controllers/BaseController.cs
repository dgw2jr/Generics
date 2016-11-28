using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.Interfaces;

namespace GenericControllerTest.Controllers
{
    public class BaseController<TModel, TKey> : ApiController
    {
        private readonly IUnitOfWork<TModel, TKey> _unitOfWork;

        public BaseController(IUnitOfWork<TModel, TKey> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/values
        public IEnumerable<TModel> Get()
        {
            return _unitOfWork.Repository.List.ToList();
        }

        // GET api/values/5
        public TModel Get(TKey id)
        {
            return _unitOfWork.Repository.FindById(id);
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]TModel value)
        {
            return HandleModel(() => _unitOfWork.Repository.Add(value));
        }

        // PUT api/values/5
        public HttpResponseMessage Put(TKey id, [FromBody]TModel value)
        {
            return HandleModel(() => _unitOfWork.Repository.Update(value));
        }

        // DELETE api/values/5
        public HttpResponseMessage Delete(TModel value)
        {
            return HandleModel(() => _unitOfWork.Repository.Delete(value));
        }

        private HttpResponseMessage HandleModel(Action action)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            action();
            var count = _unitOfWork.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK, count);
        }
    }
}