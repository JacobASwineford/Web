using Core.Contracts.Service;
using Core.Entities;
using Core.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Grader.Controllers
{
    [ApiController]
    [Route("assignment")]
    public class AssignmentController : Controller
    {
        private readonly IAssignmentServiceAsync service;
        private readonly GenericRepositoryAsync<Assignment> gen;

        public AssignmentController(IAssignmentServiceAsync service, DBC context) {
            this.service = service;
            gen = new GenericRepositoryAsync<Assignment>(context);
        }

        [HttpGet]
        [Route("allForCourse")]
        public async Task<IActionResult> AllForCourse(int courseId) {
            try {
                var r = await service.GetAllAssignmentsForCourseAsync(courseId);
                return Ok(AssignmentModel.ToList(r));
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> Post([FromBody] AssignmentModel assignment) {
            try {
                var r = await gen.PostAsync(AssignmentModel.ToEntity(assignment));
                return Ok(r);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("put")]
        public async Task<IActionResult> Put([FromBody] AssignmentModel assignment) {
            try {
                var r = await gen.PutAsync(AssignmentModel.ToEntity(assignment));
                return Ok(r);
            } catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> Delete(int assignmentId) {
            try {
                var r = await gen.DeleteAsync(assignmentId);
                return Ok(r);
            } catch (Exception e) {
                return BadRequest(e);
            }
        }
    }
}
