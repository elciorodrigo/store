using System;
using FluentValidator;
using FluentValidator.Validation;
using Store.Shared.Commands;

namespace Store.Domain.StoreContext.CustomerCommands.Input

{
    public class ComandResult : ICommandResult
    {
        public ComandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }
        public bool Success { get; set; }
        public string Message { get; set ; }
        public object Data { get; set; }
    }
}

