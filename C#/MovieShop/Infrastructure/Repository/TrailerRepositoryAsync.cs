using Core.Contracts.Repository;
using Core.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class TrailerRepositoryAsync : BaseRepositoryAsync<Trailer>, ITrailerRepositoryAsync
    {
        public TrailerRepositoryAsync(MVCDbContext _context) : base(_context) { }
    }
}
