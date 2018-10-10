using System;
using FluentValidator;
using FluentValidator.Validation;
using Store.Shared.Commands;

namespace Store.Domain.StoreContext.CustomerCommands.Outputs

{
    public class CreateCustomerCommandResult : ICommandResult
    {
        public bool Success { get; set; }
        public bool Message { get; set ; }
        public bool Data { get; set; }
    }
}

