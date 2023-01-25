using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Service
{
    public interface IScoreServiceAsync
    {
        /**
         * Asynchronously gets the current overall score of any particular student, participating in
         * any particular course.
         */
        Task<IEnumerable<Score>> GetScoresForStudentInCourse(int studentId, int courseId);
    }
}
