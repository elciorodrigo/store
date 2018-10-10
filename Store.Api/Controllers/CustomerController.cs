using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Store.Domain.StoreContext;
using Store.Domain.StoreContext.CustomerCommands.Input;
using Store.Domain.StoreContext.entities;
using Store.Domain.StoreContext.Queries;
using Store.Domain.StoreContext.Repositories;

namespace Store.Api.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerRepository _repository;
        public readonly CustomerHandler _handler;
        public CustomerController(ICustomerRepository repository, CustomerHandler handler)
        {
            _repository = repository;
            _handler = handler;
        }

        [HttpGet]
        [Route("customers")]
       // [ResponseCache(Duration = 60)]
        public IEnumerable<listCustomerQueryResult> Get()
        {

            return _repository.GetList();
        }

        [HttpGet]
        [Route("customers/{id}")]
        public GetCustomerQueryResult GetById(Guid id)
        {
            return _repository.Get(id);
        }

        [HttpGet]
        [Route("customers/{id}/orders")]
        public IEnumerable<ListCustomerOrdersQueryResult> GetOrders(Guid id)
        {
            return _repository.GetOrders(id);
        }

        [HttpPost]
        [Route("customer")]
        public Object Post([FromBody] CreateCustomerCommand command)
        { 
            var result = (CreateCustomerCommandResult)_handler.handle(command);
            if (_handler.Invalid)
                return BadRequest(_handler.Notifications);
            return result;
        }

        [HttpPut]
        [Route("customer/{id}")]
        public Customer Put([FromBody] Customer customer)
        {
            return null;
        }

        [HttpPut]
        [Route("customer/{id}")]
        public Customer Delete()
        {
            return null;
        }
    }
}
