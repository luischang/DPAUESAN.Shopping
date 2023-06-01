using DPAUESAN.Shopping.DOMAIN.Core.Entities;
using DPAUESAN.Shopping.DOMAIN.Core.Interfaces;
using DPAUESAN.Shopping.DOMAIN.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DPAUESAN.Shopping.DOMAIN.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly StoreDbContext _dbContext;

        public UserRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> SignIn(string email, string password)
        {
            return await _dbContext
                .User
                .Where(x => x.Email == email && x.Password == password)
                .FirstOrDefaultAsync();
        }

        public async Task<bool> SignUp(User user)
        {
            await _dbContext.User.AddAsync(user);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> IsEmailRegistered(string email)
        {
            return await _dbContext
                .User
                .Where(x => x.Email == email).AnyAsync();
        }
    }
}
