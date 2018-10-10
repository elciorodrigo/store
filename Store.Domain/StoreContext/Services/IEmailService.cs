using Store.Domain.StoreContext.entities;

namespace Store.Domain.StoreContext.Services
{
    public interface IEmailService
    {
        void Send(string to, string from, string subject, string body);
        
    }
}