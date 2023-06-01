using DPAUESAN.Shopping.DOMAIN.Core.Entities;

namespace DPAUESAN.Shopping.DOMAIN.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<bool> Insert(Product product);
        Task<bool> Update(Product product);
    }
}