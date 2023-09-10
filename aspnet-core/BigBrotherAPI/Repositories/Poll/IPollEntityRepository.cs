using BigBrotherAPI.Entities;
using BigBrotherAPI.Services.Dtos.Poll;
using Volo.Abp.Domain.Repositories;

namespace BigBrotherAPI.Repositories.Poll
{
    public interface IPollEntityRepository 
    {
        Task<PollEntity> GetByIdAsync(Guid pollId);
        Task<List<PollEntity>> GetAllAsync();
        Task CreateAsync(PollInputDto pollEntity);
        Task UpdateAsync(PollInputDto pollEntity);
        Task DeleteAsync(Guid id);
    }
}

