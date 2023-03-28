using Business.Abstract;
using DataAccess.EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Net6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService) 
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            var blogs = _categoryService.GetAll();
            return Ok(blogs);
        }

    }
}
