using Core.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopAPI.Controllers
{
    [ApiController]
    [Route("genre")]
    public class GenreController : Controller
    {
        IGenreServiceAsync service;
        
        public GenreController(IGenreServiceAsync service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> getAll()
        {
            var r = await service.getAllGenres();
            return Ok(r);
        }
    }
}
