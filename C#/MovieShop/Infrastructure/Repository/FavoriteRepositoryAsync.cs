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
    public class FavoriteRepositoryAsync : BaseRepositoryAsync<Favorite>, IFavoriteRepositoryAsync
    {
        public FavoriteRepositoryAsync(MVCDbContext _context) : base(_context) { }
    }
}
