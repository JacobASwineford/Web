using Core.Contracts.Repository;
using Core.Entities;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace MVC_Project.Infrastructure.Repository
{
    public class PurchaseRepositoryAsync : BaseRepositoryAsync<Purchase>, IPurchaseRepositoryAsync
    {
        public PurchaseRepositoryAsync(MVCDbContext _context) : base(_context) { }
    }
}
