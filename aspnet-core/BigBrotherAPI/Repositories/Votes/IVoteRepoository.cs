using BigBrotherAPI.Entities;
using BigBrotherAPI.Services.Dtos.Poll;
using BigBrotherAPI.Services.Dtos.Votes;

namespace BigBrotherAPI.Repositories.Votes
{
    public interface IVoteRepoository
    {
        Task<Vote> GetByIdAsync(Guid voteId);
        Task<List<Vote>> GetVotesByMotherfuckerAsync(Guid motherfuckerId);
        Task<List<Vote>> GetVotesForPollAsync(Guid pollId);
        Task CreateAsync(VoteInputDto vote);
        Task DeleteAsync(Guid voteId);
    }
}
