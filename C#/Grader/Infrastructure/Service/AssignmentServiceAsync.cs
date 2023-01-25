using Core.Contracts.Service;
using Core.Entities;
using Dapper;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class AssignmentServiceAsync : IAssignmentServiceAsync
    {
        public async Task<IEnumerable<Assignment>> GetAllAssignmentsForCourseAsync(int courseId) {
            SqlConnection conn = new(DBC.Conn);
            conn.Open();
            string sql = $"select * from assignment where courseId = {courseId}";
            IEnumerable<Assignment> assignments = await conn.QueryAsync<Assignment>(sql);
            conn.Close();
            return assignments;
        }
    }
}
