using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace BigBrotherAPI.Entities
{
    public class Vote : AggregateRoot<Guid>, ICreationAuditedObject
    {
        public string PollId { get; set; }
        public Motherfucker Motherfucker { get; set; }
        public string Reason { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid? CreatorId { get; set; }
    }
}
