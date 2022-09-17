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
    public class GenreServiceAsync : IGenreServiceAsync
    {
        IGenreRepositoryAsync rep;

        public GenreServiceAsync(IGenreRepositoryAsync rep)
        {
            this.rep = rep;
        }

        public async Task<IEnumerable<Genre>> getAllGenres()
        {
            var r = await rep.GetAllAsync();
            return r;
        }

        public async Task<IEnumerable<string>> getAllGenresByMovie(int movieId)
        {
            SqlConnection conn = new SqlConnection(MVCDbContext.MvcConnectionString);
            conn.Open();
            string sql = $"select g.name from moviegenre m join genre g on m.GenreId = g.Id where m.MovieId = {movieId}";
            IEnumerable<string> genres = await conn.QueryAsync<string>(sql);
            conn.Close();
            return genres;
        }
    }
}
