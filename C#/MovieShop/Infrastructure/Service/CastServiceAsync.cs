using Core.Contracts.Repository;
using Core.Contracts.Service;
using Core.Entities;
using Core.Models;
using Dapper;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;

namespace Infrastructure.Service
{
    public class CastServiceAsync : ICastServiceAsync
    {

        private readonly ICastRepositoryAsync rep;

        public CastServiceAsync(ICastRepositoryAsync rep)
        {
            this.rep = rep;
        }
        public async Task<IEnumerable<CastDetailsModel>> GetCastDetailsAsync(int MovieId)
        {
            SqlConnection conn = new SqlConnection(MVCDbContext.MvcConnectionString);
            conn.Open();
            string sql = "select c.Name, c.gender, c.TmdbUrl, c.ProfilePath, m.Character" +
                " from moviecast m join cast c on m.CastId = c.Id where movieid = " + MovieId;
            IEnumerable<CastDetailsModel> castlist = await conn.QueryAsync<CastDetailsModel>(sql);
            conn.Close();
            return castlist;
        }

        public async Task<Cast> GetCastByIdAsync(int id)
        {
            var r = await rep.GetByIdAsync(id);
            Console.WriteLine(r);
            return r;
        }

        public async Task<IEnumerable<Cast>> GetAllCastAsync()
        {
            var r = await rep.GetAllAsync();
            Console.WriteLine(r);
            return r;
        }

        public async Task<int> InsertCastAsync(Cast cast)
        {
            return await rep.InsertAsync(cast);
        }

        public async Task<int> DeleteCastByIdAsync(int id)
        {
            return await rep.DeleteAsync(id);
        }

        public async Task<int> UpdateCastAsync(Cast cast)
        {
            var r = await rep.UpdateAsync(cast);
            return r;
        }
    }
}
