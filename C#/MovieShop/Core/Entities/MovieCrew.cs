﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MovieCrew : Entity
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CrewId { get; set; }

        [Column(TypeName = "nvarchar(128)")]
        public string Department { get; set; }

        [Column(TypeName = "nvarchar(128)")]
        public string Job { get; set; }

        public Movie Movie { get; set; }
        public Crew Crew { get; set; }
    }
}
