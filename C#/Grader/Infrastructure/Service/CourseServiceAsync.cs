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
    public class CourseServiceAsync : ICourseServiceAsync
    {
        /**
         * Returns an enumerable list of Course from the Grader database.
         */
        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            SqlConnection conn = new(DBC.Conn);
            conn.Open();
            string sql = "select * from course";
            IEnumerable<Course> courses = await conn.QueryAsync<Course>(sql);
            conn.Close();
            return courses;
        }

        /**
         * Creates a course in the Grader database.
         */
        public Task<int> CreateCourseAsync(Course course)
        {
            throw new NotImplementedException();
        }

        /**
         * Updates a course in the Grader database with the given Course object.
         */
        public Task<int> UpdateCourseAsync(Course course)
        {
            throw new NotImplementedException();
        }

        /**
         * Deletes a course in the Grader database.
         */
        public Task<int> DeleteCourseAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
