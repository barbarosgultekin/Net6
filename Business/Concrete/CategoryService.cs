using Business.Abstract;
using DataAccess.EntitiesLayer.Concrete;
using DataAccess.Repositories;

namespace Business.Concrete
{
    public class CategoryService:ICategoryService
       
    {
         IRepository<Category> _repository;
        public CategoryService(IRepository<Category> repository)
        {
            _repository = repository;   
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Insert(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
