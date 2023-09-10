using BigBrotherAPI.Entities;

namespace BigBrotherAPI.Services.Dtos.Votes
{
    public class VoteOutputDto
    {
        public string PollId { get; set; }
        public Motherfucker Motherfucker { get; set; }
        public string Reason { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid? CreatorId { get; set; }
    }
}
