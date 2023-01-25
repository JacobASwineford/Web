using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class StudentCourseAssignmentModel
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public static IEnumerable<StudentCourseAssignmentModel> ToList(IEnumerable<StudentCourseAssignment> list) {
            List<StudentCourseAssignmentModel> assigned_list = new();
            foreach (var assigned in list)
                assigned_list.Add(FromEntity(assigned));
            return assigned_list.AsEnumerable();
        }

        public static StudentCourseAssignmentModel FromEntity(StudentCourseAssignment assigned) {
            StudentCourseAssignmentModel model = new StudentCourseAssignmentModel();
            model.Id = assigned.Id;
            model.StudentId = assigned.StudentId;
            model.CourseId = assigned.CourseId;
            return model;
        }

        public static StudentCourseAssignment ToEntity(StudentCourseAssignmentModel model) {
            StudentCourseAssignment assigned = new StudentCourseAssignment();
            assigned.Id = model.Id; 
            assigned.StudentId = model.StudentId;
            assigned.CourseId = model.CourseId;
            return assigned;
        }
    }
}
