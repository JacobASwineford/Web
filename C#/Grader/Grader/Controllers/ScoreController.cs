using Core.Contracts.Service;
using Core.Entities;
using Core.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Grader.Controllers
{
    [ApiController]
    [Route("score")]
    public class ScoreController : Controller
    {
        private readonly IScoreServiceAsync service;
        private readonly GenericRepositoryAsync<Score> gen;

        public ScoreController(IScoreServiceAsync service, DBC context) {
            this.service = service;
            gen = new GenericRepositoryAsync<Score>(context);
        }

        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> Post([FromBody] ScoreModel score) {
            try {
                var r = await gen.PostAsync(ScoreModel.ToEntity(score));
                return Ok(r);
            } catch (Exception e) {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("put")]
        public async Task<IActionResult> Put([FromBody] ScoreModel score) {
            try  {
                var r = await gen.PutAsync(ScoreModel.ToEntity(score));
                return Ok(r);
            }
            catch (Exception e) {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id) {
            try {
                var r = await gen.DeleteAsync(id);
                return Ok(r);
            }
            catch (Exception e) {
                return BadRequest(e.ToString());
            }
        }


    }
}
