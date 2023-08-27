using Volo.Abp.Domain.Entities;

namespace BigBrotherAPI.Entities
{
    public class PollResult : Entity<Guid>
    {
        public string PollId { get; set; }
        public string PollName { get; set; }
        public List<PollResultMotherfucker> Motherfuckers { get; set; }
        public DateTime PollStarteDate { get; set; }
        public DateTime PollEndDate { get; set; }
    }
}
