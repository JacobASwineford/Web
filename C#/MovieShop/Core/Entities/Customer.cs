﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Customer : Entity
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Title{ get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Address{ get; set; }

        [Column(TypeName = "varchar(20)")]
        public string City { get; set; }
        public int RegionId { get; set; }
        public int PostalCode { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Country { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Phone { get; set; }

        public Region Region { get; set; }
    }
}
