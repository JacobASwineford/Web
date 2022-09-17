using Core.Entities;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Service
{
    public interface IGenreServiceAsync
    {
        Task<IEnumerable<string>> getAllGenresByMovie(int movieId);
        Task<IEnumerable<Genre>> getAllGenres();
    }
}
