using Core.Entities;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Service
{
    public interface IUserServiceAsync
    {
        Task<IEnumerable<Movie>> getPurchasedMovies();
        Task<IEnumerable<Movie>> getFavoritedMovies();
        Task<int> deletePurchasedMovie(int id);
        Task<int> deleteFavoritedMovie(int id);
    }
}
