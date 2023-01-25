using Core.Entities;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Service
{
    public interface IStudentServiceAsync
    {
        /**
         * Asynchronously gets all the students present in the grader database.
         */
        Task<IEnumerable<Student>> GetAllStudentsAsync();
    }
}
