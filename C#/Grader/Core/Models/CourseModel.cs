using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Section { get; set; }

        public static IEnumerable<CourseModel> ToList(IEnumerable<Course> list) {
            List<CourseModel> courses = new();
            foreach (Course course in list)
                courses.Add(FromEntity(course));
            return courses.AsEnumerable();
        }

        public static CourseModel FromEntity(Course course) {
            CourseModel model = new CourseModel();
            model.Id = course.Id;
            model.Name = course.Name;
            model.Section = course.Section;
            return model;
        }

        public static Course ToEntity(CourseModel model) {
            Course course = new Course();
            course.Id = model.Id;
            course.Name = model.Name;
            course.Section = model.Section;
            return course;
        }
    }
}
