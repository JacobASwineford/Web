using Core.Contracts.Service;
using Core.Entities;
using Core.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Grader.Controllers
{
    [Route("course")]
    [ApiController]
    public class CourseController : Controller
    {
        private readonly ICourseServiceAsync service;
        private readonly GenericRepositoryAsync<Course> gen;

        public CourseController(ICourseServiceAsync service, DBC context) {
            this.service = service;
            gen = new GenericRepositoryAsync<Course>(context);
        }

        /**
         * Gets all the courses available in the Graders Database.
         */
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAll() {
            try {
                var r = await service.GetAllCoursesAsync();
                return Ok(CourseModel.ToList(r));
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        /**
         * Creates the course represented by the given course model.
         */
        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> Post([FromBody] CourseModel course) {
            try {
                var r = await gen.PostAsync(CourseModel.ToEntity(course));
                return Ok(r);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        /**
         * Updates the course represented by the given course model.
         * More specifically, the course with the given id will be appended with the
         * new information present in the course model.
         */
        [HttpPut]
        [Route("put")]
        public async Task<IActionResult> Put([FromBody] CourseModel course) {
            try {
                var r = await gen.PutAsync(CourseModel.ToEntity(course));
                return Ok(r);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        /**
         * Deletes the course represented by the given course model.
         */
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> Delete(int courseId) {
            try {
                var r = await gen.DeleteAsync(courseId);
                return Ok(r);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}
