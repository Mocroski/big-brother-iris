using BigBrotherAPI.Entities;

namespace BigBrotherAPI.Repositories.Motherfuckers
{
    public interface IMotherfuckerRepository
    {
        Task<Motherfucker> GetByIdAsync(Guid id);
        Task<List<Motherfucker>> GetAllAsync();
        Task<Motherfucker> AddAsync()
    }
}
