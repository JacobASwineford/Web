using Core.Contracts.Repository;
using Core.Contracts.Service;
using Core.Entities;
using Dapper;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using MVC_Project.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class PurchaseServiceAsync : IPurchasesServiceAsync
    {
        IPurchaseRepositoryAsync rep;

        public PurchaseServiceAsync(IPurchaseRepositoryAsync rep)
        {
            this.rep = rep;
        }

        public async Task<int> deletePurchaseById(int id)
        {
            var r = await rep.DeleteAsync(id);
            return r;
        }

        public async Task<IEnumerable<Purchase>> getPurchasesByUserId(int id)
        {
            SqlConnection conn = new SqlConnection(MVCDbContext.MvcConnectionString);
            conn.Open();
            string sql = $"select * from purchase where userid = {id}";
            IEnumerable<Purchase> purs = await conn.QueryAsync<Purchase>(sql);
            conn.Close();
            return purs;
        }
    }
}
