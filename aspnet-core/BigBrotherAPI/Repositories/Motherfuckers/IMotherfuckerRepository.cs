using BigBrotherAPI.Entities;
using BigBrotherAPI.Services.Dtos.Motherfuckers;

namespace BigBrotherAPI.Repositories.Motherfuckers
{
    public interface IMotherfuckerRepository
    {
        Task<Motherfucker> GetByIdAsync(Guid id);
        Task<List<Motherfucker>> GetAllAsync();
        Task<Motherfucker> AddAsync(MotherfuckerInputDto motherfucker);
        Task DeleteAsync(Guid id);
    }
}
