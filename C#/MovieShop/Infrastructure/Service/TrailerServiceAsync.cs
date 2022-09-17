using Core.Contracts.Repository;
using Core.Contracts.Service;
using Core.Entities;
using Dapper;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class TrailerServiceAsync : ITrailerServiceAsync
    {
        ITrailerRepositoryAsync rep;

        public TrailerServiceAsync(ITrailerRepositoryAsync rep)
        {
            this.rep = rep;
        }

        public Task<IEnumerable<Trailer>> GetTrailerByMovie(int movieId)
        {
            SqlConnection conn = new SqlConnection(MVCDbContext.MvcConnectionString);
            conn.Open();
            string sql = $"get * from trailer where movieid = {movieId}";
            Task<IEnumerable<Trailer>> stuff = conn.QueryAsync<Trailer>(sql);
            conn.Close();
            return stuff;
        }
    }
}
