using BigBrotherAPI.Entities;
using BigBrotherAPI.Repositories.Votes;
using BigBrotherAPI.Services.Dtos.Votes;

namespace BigBrotherAPI.Services.Votes
{
    public class VoteService : IVoteService
    {
        private readonly IVoteRepoository _voteRepository;
        public VoteService(IVoteRepoository voteRepository)
        {
            _voteRepository = voteRepository;
        }
        public async Task<Vote> CreateVoteAsync(VoteInputDto voteInputDto)
        {
            throw new NotImplementedException();

        }

        public Task EliminateMotherfuckersAsync(Guid pollId)
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<Guid, int>> GetVoteCountsAsync(Guid pollId)
        {
            throw new NotImplementedException();
        }

        public Task<List<VoteOutputDto>> GetVotesByMotherfuckerAsync(Guid motherfuckerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<VoteOutputDto>> GetVotesForPollAsync(Guid pollId)
        {
            throw new NotImplementedException();
        }
    }
}
