namespace BigBrotherAPI.Services.Dtos.Votes
{
    public class VoteInputDto
    {
        public Guid PollId { get; set; }
        public Guid MotherfuckerId { get; set; }
        public string Reason { get; set; }
    }
}
