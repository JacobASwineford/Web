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
    }
}
