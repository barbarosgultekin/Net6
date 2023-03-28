using DataAccess.EntitiesLayer.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService 
         
    {
        Task<Category> Get(int id);

        Task<List<Category>> GetAll();

        Task<int> Insert(Category entity);

        Task Update(int id, Category entity);
     
        Task Delete(int id);
    }
}
