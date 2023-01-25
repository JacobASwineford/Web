using Core.Contracts.Service;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class ScoreServiceAsync : IScoreServiceAsync
    {

        public Task<IEnumerable<Score>> GetScoresForStudentInCourse(int studentId, int courseId)
        {
            throw new NotImplementedException();
        }
    }
}
