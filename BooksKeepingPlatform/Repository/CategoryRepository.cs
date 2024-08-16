using BooksKeepingPlatform1.Data;
using BooksKeepingPlatform1.Models;
using BooksKeepingPlatform1.Repository.IRepository;

namespace BooksKeepingPlatform1.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
