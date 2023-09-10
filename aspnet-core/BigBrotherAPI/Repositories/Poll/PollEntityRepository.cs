using BigBrotherAPI.Data;
using BigBrotherAPI.Entities;
using BigBrotherAPI.Services.Dtos.Poll;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace BigBrotherAPI.Repositories.Poll
{
    public class PollEntityRepository : EfCoreRepository<BigBrotherAPIDbContext, PollEntity, Guid>,  IPollEntityRepository
    {
        public PollEntityRepository(IDbContextProvider<BigBrotherAPIDbContext> dbContextProvider) : base(dbContextProvider) { }

        public async Task CreateAsync(PollInputDto pollEntity)
        {
            var dbContext = await GetDbContextAsync();
            var poll = new PollEntity
            {
                Name = pollEntity.Name,
                Message = pollEntity.Message
            };

        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PollEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PollEntity> GetByIdAsync(Guid pollId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PollInputDto pollEntity)
        {
            throw new NotImplementedException();
        }
    }
}
