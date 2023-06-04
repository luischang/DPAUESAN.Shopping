using DPAUESAN.Shopping.DOMAIN.Core.Entities;
using DPAUESAN.Shopping.DOMAIN.Core.Interfaces;
using DPAUESAN.Shopping.DOMAIN.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAUESAN.Shopping.DOMAIN.Infrastructure.Repositories
{
    public class FavoriteRepository : IFavoriteRepository
    {
        private readonly StoreDbContext _storeContext;

        public FavoriteRepository(StoreDbContext storeContext)
        {
            _storeContext = storeContext;
        }

        public async Task<IEnumerable<Favorite>> GetAll(int userId)
        {
            var favorites = await _storeContext
                            .Favorite
                            .Where(f => f.UserId == userId)
                            .Include(x => x.User)
                            .Include(z => z.Product)
                            .ThenInclude(c => c.Category)
                            .ToListAsync();
            return favorites;
        }
    }
}
