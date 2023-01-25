using Core.Contracts;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class AssignmentModel
    {
        public int Id { get; set; }
        public double Outof { get; set; }
        public string? Name { get; set; }
        public int CourseId { get; set; }

        public static IEnumerable<AssignmentModel> ToList(IEnumerable<Assignment> list) {
            List<AssignmentModel> assignments = new();
            foreach (Assignment assignment in list)
                assignments.Add(FromEntity(assignment));
            return assignments.AsEnumerable();
        }

        public static AssignmentModel FromEntity(Assignment assignment) {
            AssignmentModel model = new AssignmentModel();
            model.Id = assignment.Id;
            model.Outof = assignment.OutOf;
            model.Name = assignment.Name;
            model.CourseId = assignment.CourseId;
            return model;
        }

        public static Assignment ToEntity(AssignmentModel model) {
            Assignment assignment = new Assignment();
            assignment.Id = model.Id;
            assignment.OutOf = model.Outof;
            assignment.Name = model.Name;
            assignment.CourseId = model.CourseId;
            return assignment;
        }
    }
}
