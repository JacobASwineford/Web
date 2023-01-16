using Core.Contracts.Service;
using Core.Entities;
using Core.Models;
using Dapper;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class StudentServiceAsync : IStudentServiceAsync
    {

        /**
         * Returns an enumerable list of Student from the Grader Database.
         */
        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            SqlConnection conn = new(DBC.Conn);
            conn.Open();
            string sql = "select id, firstname, lastname from student";
            IEnumerable<Student> students = await conn.QueryAsync<Student>(sql);
            conn.Close();
            return students;
        }

        /**
         * Enrolls a student into the Grader Dataabase, Using a Student object.
         */
        public Task<int> EnrollStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }

        /**
         * Updates a student's credentials using their Grader id.
         */
        public Task<int> UpdateStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }
        
        /**
         * Deletes a student from the Grader Database based on their student id.
         */
        public Task<int> DeleteStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        /**
         * Gets a list of any particular student's courses in the Grader database.
         */
        public async Task<IEnumerable<Course>> GetStudentCoursesAsync(int id) {
            SqlConnection conn = new(DBC.Conn);
            conn.Open();
            string sql = $"select sca.id c.name, sca.section from studentcourseassignment sca " +
                $"join course c on c.id = sca.courseid join student s on s.id = sca.studentid " +
                $"where s.id = '{id}' order by c.name asc";
            IEnumerable<Course> courses = await conn.QueryAsync<Course>(sql);
            conn.Close();
            return courses;
        }

        /**
         * Assigns a student with the given id to a course with the given id.
         */
        public async Task<int> AssignAsync(int studentId, int courseId) {
            throw new NotImplementedException();
        }

        /**
         * Designs a student with the given id to a course with the given id.
         */
        public async Task<int> DesignAsync(int studentId, int courseId) {
            throw new NotImplementedException();
        }
    }
}
