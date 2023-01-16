using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class DBC : IdentityDbContext<ApplicationUser>
    {
        public const string Conn = "Data Source=localhost;Initial Catalog=Grader;Integrated Security=True";
        public DBC(DbContextOptions<DBC> options) : base(options) {}
        public DbSet<Student>? Student { get; set; }
        public DbSet<Course>? Course { get; set; }
        public DbSet<Assignment>? Assignment { get; set; }
        public DbSet<Score>? Score { get; set; }
        public DbSet<StudentCourseAssignment>? StudentCourseAssignment { get; set; }
    }
}
