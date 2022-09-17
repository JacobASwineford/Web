using Core.Contracts.Repository;
using Core.Contracts.Service;
using Core.Entities;
using Dapper;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class FavoriteServiceAsync : IFavoriteServiceAsync
    {
        IFavoriteRepositoryAsync rep;

        public FavoriteServiceAsync(IFavoriteRepositoryAsync rep)
        {
            this.rep = rep;
        }

        public async Task<int> deleteFavoritesById(int id)
        {
            var r = await rep.DeleteAsync(id);
            return r;
        }

        public async Task<IEnumerable<Favorite>> getFavoritesByUserId(int id)
        {
            SqlConnection conn = new SqlConnection(MVCDbContext.MvcConnectionString);
            conn.Open();
            string sql = $"select * from favorite where userid = {id}";
            IEnumerable<Favorite> favs = await conn.QueryAsync<Favorite>(sql);
            conn.Close();
            return favs;
        }
    }
}
