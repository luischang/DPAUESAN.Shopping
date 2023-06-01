using DPAUESAN.Shopping.DOMAIN.Core.Entities;

namespace DPAUESAN.Shopping.DOMAIN.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> IsEmailRegistered(string email);
        Task<User> SignIn(string email, string password);
        Task<bool> SignUp(User user);
    }
}