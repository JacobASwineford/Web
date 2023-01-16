using Core.Contracts.Service;
using Core.Entities;
using Core.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Grader.Controllers
{
    [Route("student")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentServiceAsync service;

        /**
         * Constructor to initilize services, via dependency injection.
         */
        public StudentController(IStudentServiceAsync ss) {
            service = ss;
        }

        /**
         * Gets all the students from the Grader database.
         */
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAll() {
            try {
                var r = await service.GetAllStudentsAsync();
                return Ok(r);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        /**
         * Enrolls the student represented by the given student model.
         */
        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> Enroll([FromBody] StudentModel student) {
            try {
                var r = await service.EnrollStudentAsync(StudentModel.ToEntity(student));
                return Ok(r);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        /**
         * Updates the student represented by the given student model.
         * More specifically, the student with the given id will be appended with the new
         * information present in the student model.
         */
        [HttpPut]
        [Route("put")]
        public async Task<IActionResult> Change([FromBody] StudentModel student) {
            try {
                var r = await service.UpdateStudentAsync(StudentModel.ToEntity(student)); // assumes student model is same as student
                return Ok(r);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        /**
         * Deletes the student represented by the given student model.
         */
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> Delete(int studentId) {
            try {
                var r = await service.DeleteStudentAsync(studentId);
                return Ok(r);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        /**
         * Gets the students courses, which correspond to the given student's id
         */
        [HttpGet]
        [Route("courses")]
        public async Task<IActionResult> GetCourses(int id)
        {
            try {
                var r = await service.GetStudentCoursesAsync(id);
                return Ok(r);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}
