namespace BigBrotherAPI.Services.Dtos.Votes
{
    public class VoteOutputDto
    {
        public Guid Id { get; set; }
        public Guid PollId { get; set; }
        public Guid Reason { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
