using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class GenericRepositoryAsync<T> where T : class
    {
        private readonly DBC context;

        /**
         * Contructor for dependency injection of database context.
         */
        public GenericRepositoryAsync(DBC context) {
            this.context = context;
        }

        /**
         * Deletes a record from an existing database table, using it's id.
         * The type of generic entity this class obtains generically determines
         * which table is used.
         */
        public async Task<int> DeleteAsync(int id) {
            var e = await context.Set<T>().FindAsync(id);
            if (e != null) context.Set<T>().Remove(e);
            return await context.SaveChangesAsync();
        }
        
        /**
         * Posts a record from an existing table, using it's given entity object.
         * The type of entity object also determines what table is used.
         */
        public async Task<int> PostAsync(T e) {
            context.Set<T>().Add(e);
            return await context.SaveChangesAsync();
        }

        /**
         * Updates a record from an existing table, using it's given entity object.
         * The type of entity object also determines what table is used.
         */
        public async Task<int> PutAsync(T e) {
            context.Update(e);
            return await context.SaveChangesAsync();
        }
    }
}
