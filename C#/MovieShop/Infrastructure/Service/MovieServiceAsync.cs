using Core.Contracts.Repository;
using Core.Contracts.Service;
using Core.Entities;
using Core.Models;
using Dapper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Data.Common;
using System.Data.SqlClient;

namespace Infrastructure.Service
{
    public class MovieServiceAsync : IMovieServiceAsync
    {

        private readonly IMovieRepositoryAsync rep;

        public MovieServiceAsync(IMovieRepositoryAsync repo)
		{
            rep = repo;
		}

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            var r = await rep.GetAllAsync();
            return r;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var r = await rep.GetByIdAsync(id);
            return r;
        }

        public async Task<int> InsertMovieAsync(Movie movie)
        {
            var r = await rep.InsertAsync(movie);
            return r;
        }

        public async Task<int> DeleteMovieByIdAsync(int id)
        {
            var r = await rep.DeleteAsync(id);
            return r;
        }

        public async Task<int> DeleteMovieByTitleAsync(string title)
        {
            SqlConnection conn = new SqlConnection(MVCDbContext.MvcConnectionString);
            conn.Open();
            string sql = $"delete from movie where title = \'{title}\'";
            int task = await conn.ExecuteAsync(sql);
            conn.Close();
            return task;
        }

        public async Task<int> UpdateMovieAsync(Movie movie)
        {
            var r = await rep.UpdateAsync(movie);
            return r;
        }

        public Task<IEnumerable<Movie>> GetMoviesByGenreName(string genreName)
        {
            SqlConnection conn = new SqlConnection(MVCDbContext.MvcConnectionString);
            conn.Open();
            string sql = $"";
            conn.Close();
            return null;
        }
    }
}
