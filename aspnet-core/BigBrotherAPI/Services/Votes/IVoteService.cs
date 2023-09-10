using BigBrotherAPI.Entities;
using BigBrotherAPI.Services.Dtos.Votes;

namespace BigBrotherAPI.Services.Votes
{
    public interface IVoteService
    {
        Task <Vote>CreateVoteAsync(VoteInputDto voteInputDto);
        Task<List<VoteOutputDto>> GetVotesByMotherfuckerAsync(Guid motherfuckerId);
        Task<List<VoteOutputDto>> GetVotesForPollAsync(Guid pollId);
        Task EliminateMotherfuckersAsync(Guid pollId);
        Task<Dictionary<Guid, int>> GetVoteCountsAsync(Guid pollId);
    }
}
