using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Service
{
    public interface IAssignmentServiceAsync
    {

        /**
         * Asynchronously gets all the current assignments for any particular course.
         */
        Task<IEnumerable<Assignment>> GetAllAssignmentsForCourseAsync(int courseId);
    }
}
