using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UKRecipe.Entities.Dtos;
using UKRecipe.Services.Abstract;

namespace UKRecipe.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryServices;
        public CategoryController(ICategoryService categoryServices)
        {
            _categoryServices = categoryServices;
        }
        [HttpGet("get/{categoryId}")]
        public async Task<IActionResult> Get(int categoryId)
        {
            var result = await _categoryServices.GetAsync(categoryId);
         

            return Ok(result.Data);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _categoryServices.GetAllAsync();
        
            return Ok(result.Data.Categories);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            var result = await _categoryServices.AddAsync(categoryAddDto);


            return Ok(result);

        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int categoryId)
        {
            var result = await _categoryServices.DeleteAsync(categoryId);

            return Ok(result);
        }

    }
}
