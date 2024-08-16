using BooksKeepingPlatform1.Models;

namespace BooksKeepingPlatform1.Repository.IRepository
{
   
        public interface ICategoryRepository : IRepository<Category>
        {
            void Update(Category obj);
        }
    
}
