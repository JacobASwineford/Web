using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Course
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string? Section { get; set; }
    }
}
