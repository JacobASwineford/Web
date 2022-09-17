using Core.Entities;
using Core.Models;

namespace Core.Contracts.Service
{
    public interface ICastServiceAsync
    {
        public Task<Cast> GetCastByIdAsync(int id);

        public Task<IEnumerable<Cast>> GetAllCastAsync();

        public Task<IEnumerable<CastDetailsModel>> GetCastDetailsAsync(int MovieId);

        public Task<int> InsertCastAsync(Cast cast);
        public Task<int> DeleteCastByIdAsync(int id);
        public Task<int> UpdateCastAsync(Cast cast);
    }
}
