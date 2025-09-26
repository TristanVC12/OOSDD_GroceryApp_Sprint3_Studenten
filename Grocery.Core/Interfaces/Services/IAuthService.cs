
using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services
{
    public interface IAuthService
    {
        bool Register(Client client);
        Client? Login(string email, string password);
    }
}
