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
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<int> EnrollStudentAsync(Student student);
        Task<int> UpdateStudentAsync(Student student);
        Task<int> DeleteStudentAsync(int id);
        Task<IEnumerable<Course>> GetStudentCoursesAsync(int id);
        Task<int> AssignAsync(int studentId, int courseId);
        Task<int> DesignAsync(int studentId, int courseId);
    }
}
