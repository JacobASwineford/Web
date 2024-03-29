﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Student
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string? FirstName { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string? LastName { get; set; }
    }
}
