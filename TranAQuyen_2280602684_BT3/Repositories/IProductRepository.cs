using TranAQuyen_2280602684_BT3.Models;
namespace TranAQuyen_2280602684_BT3.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddProductImageAsync(ProductImage image);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
