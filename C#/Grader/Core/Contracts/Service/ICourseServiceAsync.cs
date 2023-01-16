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
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task<int> CreateCourseAsync(Course course);
        Task<int> UpdateCourseAsync(Course course);
        Task<int> DeleteCourseAsync(int id);
    }
}
