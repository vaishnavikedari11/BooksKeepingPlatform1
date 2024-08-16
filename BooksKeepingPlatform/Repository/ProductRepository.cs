using BooksKeepingPlatform1.Data;
using BooksKeepingPlatform1.Models;
using BooksKeepingPlatform1.Repository.IRepository;

namespace BooksKeepingPlatform1.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
