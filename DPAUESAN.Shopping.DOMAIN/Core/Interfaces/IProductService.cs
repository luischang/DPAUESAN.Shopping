using DPAUESAN.Shopping.DOMAIN.Core.DTO;

namespace DPAUESAN.Shopping.DOMAIN.Core.Interfaces
{
    public interface IProductService
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<ProductCategoryDTO>> GetAll();
        Task<ProductCategoryDTO> GetById(int id);
        Task<bool> Insert(ProductInsertDTO productDTO);
        Task<bool> Update(ProductDTO productDTO);
    }
}