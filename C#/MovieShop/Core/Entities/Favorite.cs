using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Favorite : Entity
    {
        public int Id { get; set; }
        public int MovieId { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        public string UserId { get; set; }

        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
