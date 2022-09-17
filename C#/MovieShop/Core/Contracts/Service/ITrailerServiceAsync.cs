using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Service
{
    public interface ITrailerServiceAsync
    {
        public Task<IEnumerable<Trailer>> GetTrailerByMovie(int movieId);
    }
}
