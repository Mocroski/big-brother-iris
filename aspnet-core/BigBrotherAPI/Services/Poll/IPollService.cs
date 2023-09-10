namespace BigBrotherAPI.Services.Poll
{
    public interface IPollService
    {
        Task VoteAsync(Guid pollId, Guid motherfuckerId, string reason);
        Task<Dictionary<Guid, int>> GetVoteCountsAsync(Guid pollId);
        Task EliminateMothefuckersAsync(Guid pollId);
    }
}
