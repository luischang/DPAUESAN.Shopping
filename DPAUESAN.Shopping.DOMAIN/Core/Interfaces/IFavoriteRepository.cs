using DPAUESAN.Shopping.DOMAIN.Core.Entities;

namespace DPAUESAN.Shopping.DOMAIN.Core.Interfaces
{
    public interface IFavoriteRepository
    {
        Task<IEnumerable<Favorite>> GetAll(int userId);
    }
}