using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Connections
    {
        public static SqlConnection Checkers()
        {
            return new SqlConnection("Data Source=localhost;Initial Catalog=Checkers;Integrated Security=True");
        }

        public static SqlConnection Chess()
        {
            return new SqlConnection("Data Source=localhost;Initial Catalog=Chess;Integrated Security=True");
        }


    }
}
