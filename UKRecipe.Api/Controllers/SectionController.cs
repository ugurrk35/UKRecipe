using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UKRecipe.Services.Abstract;

namespace UKRecipe.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly ISectionService _sectionService;
        public SectionController(ISectionService sectionService)
        {
           _sectionService= sectionService;
        }
        [HttpGet]
        public async Task<IActionResult> Get(int sectionId)
        {
            var result = await _sectionService.GetAsync(sectionId);


            return Ok(result.Data);
        }
    }
}
