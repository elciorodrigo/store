using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Store.Domain.StoreContext.entities;
using Store.Domain.StoreContext.Queries;
using Store.Domain.StoreContext.Repositories;

namespace Store.Infra.DataContext.Repositories
{
    public class CustomerRespository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRespository(DataContext context)
        {
            _context = context;
        }

        public bool CheckDocument(string document)
        {
            return _context
                .Connection
                .Query<bool>(
                    "spCheckDocument",
                    new { Document = document },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
        }

        public bool CheckEmail(string email)
        {
            return _context
            .Connection
            .Query<bool>(
                "spCheckEmail",
                    new { Email = email },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();

        }

        public GetCustomerQueryResult Get(Guid id)
        {
            return
                _context
                .Connection
                .Query<GetCustomerQueryResult>(
                    "SELECT [Id], CONCAT([FirstName], ' ', [LastName]) AS [Name], [Document], [Email] FROM [Customer] WHERE [Id]=@id"
                    , new { id = id })
                    .FirstOrDefault();
        }

        public CustomerOrdersCountResult GetCustomerOrdersCount(string document)
        {
            return _context
           .Connection
           .Query<CustomerOrdersCountResult>(
               "spCheckEmail",
                   new { Document = document },
                   commandType: CommandType.StoredProcedure)
               .FirstOrDefault();
        }

        public IEnumerable<listCustomerQueryResult> GetList()
        {
            return
                _context
                .Connection
                .Query<listCustomerQueryResult>(
                    "SELECT [Id], CONCAT([FirstName], ' ', [LastName]) AS [Name], [Document], [Email] FROM [Customer]"
                    , new { });
        }

        public IEnumerable<ListCustomerOrdersQueryResult> GetOrders(Guid id)
        {
            return
               _context
               .Connection
               .Query<ListCustomerOrdersQueryResult>(
                   "", new { id = id });
        }

        public void Save(Customer customer)
        {
            _context.Connection.Execute("spCreateCustomer",
           new
           {
               Id = customer.Id,
               FirstName = customer.Name.FirstName,
               LastName = customer.Name.LastName,
               Document = customer.Document.Number,
               Email = customer.Email.Address,
               Phone = customer.Phone
           }, commandType: CommandType.StoredProcedure);

            foreach (var address in customer.Addresses)
            {
                _context.Connection.Execute("spCreateAddress",
                new
                {
                    Id = address.Id,
                    CustomerId = customer.Id,
                    Number = address.Number,
                    Complement = address.Complement,
                    District = address.District,
                    City = address.City,
                    State = address.State,
                    Country = address.Country,
                    ZipCode = address.ZipCode,
                    Type = address.Type,
                }, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
