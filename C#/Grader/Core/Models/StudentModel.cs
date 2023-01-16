using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Core.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public static IEnumerable<StudentModel> ToList(IEnumerable<Student> list) {
            IEnumerable<StudentModel> result = new List<StudentModel>();
            foreach (Student student in list)
                result.Append(FromEntity(student));
            return result;
        }

        public static StudentModel FromEntity(Student student) {
            StudentModel model = new StudentModel();
            model.FirstName = student.FirstName;
            model.LastName = student.LastName;
            return model;
        }

        public static Student ToEntity(StudentModel model) {
            Student student = new Student();
            student.Id = model.Id;
            student.FirstName = model.FirstName;
            student.LastName = model.LastName;
            return student;
        }
    }
}
