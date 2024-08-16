using BooksKeepingPlatform1.Models;

namespace BooksKeepingPlatform1.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
