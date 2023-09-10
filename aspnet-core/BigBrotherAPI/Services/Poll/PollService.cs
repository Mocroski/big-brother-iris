namespace BigBrotherAPI.Services.Poll
{
    public class PollService : IPollService
    {
        public Task EliminateMothefuckersAsync(Guid pollId)
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<Guid, int>> GetVoteCountsAsync(Guid pollId)
        {
            throw new NotImplementedException();
        }

        public Task VoteAsync(Guid pollId, Guid motherfuckerId, string reason)
        {
            throw new NotImplementedException();
        }
    }
}
