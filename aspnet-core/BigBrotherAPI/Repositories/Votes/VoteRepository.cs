using BigBrotherAPI.Data;
using BigBrotherAPI.Entities;
using BigBrotherAPI.Services.Dtos.Votes;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BigBrotherAPI.Repositories.Votes
{
    public class VoteRepository : EfCoreRepository<BigBrotherAPIDbContext, Vote, Guid>, IVoteRepoository
    {
        public VoteRepository(IDbContextProvider<BigBrotherAPIDbContext> dbContextProvider) : base(dbContextProvider) { }
        public async Task CreateAsync(VoteInputDto voteDto)
        {
            var dbContext = await GetDbContextAsync();
            var vote = new Vote
            {
                Motherfucker = voteDto.Motherfucker,
                Reason = voteDto.Reason,
            };

            var entityEntry = await dbContext.Set<Vote>().AddAsync(vote);

            await dbContext.SaveChangesAsync();

        }

        public Task DeleteAsync(Guid voteId)
        {
            throw new NotImplementedException();
        }

        public Task<Vote> GetByIdAsync(Guid voteId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Vote>> GetVotesByMotherfuckerAsync(Guid motherfuckerId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Vote>> GetVotesForPollAsync(Guid pollId)
        {
            var dbContext = await GetDbContextAsync();
            var votes = await dbContext.Set<Vote>()
                .Where(vote => vote.PollId == pollId)
                .ToListAsync();
            return votes;
        }
    }
}
