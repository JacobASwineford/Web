using Core.Entities;
using Core.Models;

namespace Core.Contracts.Service
{
    public interface IMovieServiceAsync
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
		Task<Movie> GetMovieByIdAsync(int id);
        Task<IEnumerable<Movie>> GetMoviesByGenreName(string genreName);
        Task<int> InsertMovieAsync(Movie movie);
        Task<int> UpdateMovieAsync(Movie movie);
        Task<int> DeleteMovieByIdAsync(int id);

    }
}
