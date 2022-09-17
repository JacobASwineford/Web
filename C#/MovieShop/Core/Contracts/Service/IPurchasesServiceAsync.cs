using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Service
{
    public interface IPurchasesServiceAsync
    {
        Task<IEnumerable<Purchase>> getPurchasesByUserId(int id);
        Task<int> deletePurchaseById(int id);
    }
}
