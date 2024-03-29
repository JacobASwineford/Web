﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Crew : Entity
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(128)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Gender { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string TmdbUrl { get; set; }

        [Column(TypeName = "nvarchar(2084)")]
        public string ProfilePath { get; set; }
    }
}
