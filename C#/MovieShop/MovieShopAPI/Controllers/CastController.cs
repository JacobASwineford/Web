using Core.Contracts.Service;
using Core.Entities;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopAPI.Controllers
{
    [Route("cast")]
    public class CastController : ControllerBase
    {
        private readonly ICastServiceAsync service;

        public CastController(ICastServiceAsync service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetAll()
        {
            var r = await service.GetAllCastAsync();
            return Ok(r);
        }

        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var r = await service.GetCastByIdAsync(id);
            return Ok(r);
        } 

        [HttpGet]
        [Route("details/{movieId}")]
        public async Task<IActionResult> Details(int movieId)
        {
            var r = await service.GetCastDetailsAsync(movieId);
            return Ok(r);
        }

        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> Post([FromBody] Cast cast)
        {
            var r = await service.InsertCastAsync(cast);
            return Ok(r);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var r = await service.DeleteCastByIdAsync(id);
            return Ok(r);
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] Cast cast)
        {
            var r = await service.UpdateCastAsync(cast);
            return Ok(r);
        }
    }
}
