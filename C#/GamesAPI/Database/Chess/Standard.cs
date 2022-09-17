using Dapper;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Chess
{
    public class Standard
    {
        public static IEnumerable<Leaderboard> getLeaderboard()
        {
            SqlConnection con = Connections.Chess();

            con.Open();
            IEnumerable<Leaderboard> all =
                con.Query<Leaderboard>("select * from standard_leaderboard");
            con.Close();

            return all;
        }
    }
}
