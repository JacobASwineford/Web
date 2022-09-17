using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DatabaseModel
    {
        public List<string> tables;
        public List<string> columns;
        public List<List<string>> rows;
        public string dbname;
    }
}
