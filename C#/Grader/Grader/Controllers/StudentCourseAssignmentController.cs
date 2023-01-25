using Core.Contracts.Service;
using Core.Entities;
using Core.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Grader.Controllers
{
    [ApiController]
    [Route("studentCourseAssignment")]
    public class StudentCourseAssignmentController : Controller
    {
        private readonly IStudentCourseAssignmentServiceAsync service;
        private readonly GenericRepositoryAsync<StudentCourseAssignment> gen;

        public StudentCourseAssignmentController(IStudentCourseAssignmentServiceAsync service, DBC context) {
            this.service = service;
            gen = new GenericRepositoryAsync<StudentCourseAssignment>(context);
        }

        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> Post([FromBody] StudentCourseAssignmentModel assigned) {
            try {
                var r = await gen.PostAsync(StudentCourseAssignmentModel.ToEntity(assigned));
                return Ok(r);
            }
            catch (Exception e) {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("put")]
        public async Task<IActionResult> Put([FromBody] StudentCourseAssignmentModel assigned) {
            try {
                var r = await gen.PutAsync(StudentCourseAssignmentModel.ToEntity(assigned));
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
