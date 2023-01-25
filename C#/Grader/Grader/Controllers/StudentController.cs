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
        private readonly GenericRepositoryAsync<Student> gen;

        /**
         * Constructor to initilize services, via dependency injection.
         */
        public StudentController(IStudentServiceAsync service, DBC context) {
            this.service = service;
            gen = new GenericRepositoryAsync<Student>(context);
        }

        /**
         * Gets all the students from the Grader database.
         */
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAll() {
            try {
                var r = await service.GetAllStudentsAsync();
                return Ok(StudentModel.ToList(r));
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
        public async Task<IActionResult> Post([FromBody] StudentModel student) {
            try {
                var r = await gen.PostAsync(StudentModel.ToEntity(student));
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
        public async Task<IActionResult> Put([FromBody] StudentModel student) {
            try {
                var r = await gen.PutAsync(StudentModel.ToEntity(student));
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
                var r = await gen.DeleteAsync(studentId);
                return Ok(r);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}
