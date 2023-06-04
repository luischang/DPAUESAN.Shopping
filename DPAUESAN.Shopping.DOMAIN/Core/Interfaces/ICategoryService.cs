using DPAUESAN.Shopping.DOMAIN.Core.DTO;

namespace DPAUESAN.Shopping.DOMAIN.Core.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDescriptionDTO>> GetAll();
        Task<CategoryDescriptionDTO> GetById(int id);
    }
}