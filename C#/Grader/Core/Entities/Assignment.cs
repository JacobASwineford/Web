using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Assignment
    {
        public int Id { get; set; }
        public double OutOf { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        
       
    }
}
