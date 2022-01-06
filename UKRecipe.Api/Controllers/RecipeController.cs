using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UKRecipe.Services.Abstract;

namespace UKRecipe.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        public RecipeController(IRecipeService recipeService)
        {
            _recipeService=recipeService;
        }
        [HttpGet]
        public async Task<IActionResult> Get(int recipeId)
        {
            var result = await _recipeService.GetAsync(recipeId);


            return Ok(result.Data);
        }
    }
}
