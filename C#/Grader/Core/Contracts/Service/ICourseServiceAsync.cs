using Core.Entities;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Service
{
    public interface ICourseServiceAsync
    {
        /**
         * Asynchronously gets all the courses present in the grader database.
         */
        Task<IEnumerable<Course>> GetAllCoursesAsync();
    }
}
