using Volo.Abp.Domain.Entities;

namespace BigBrotherAPI.Entities
{
    public class PollEntity : Entity<Guid>
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public List<Motherfucker> Motherfuckers { get; set;}
        public DateTime CreationTime { get; set; }
        public DateTime ClosureTime { get; set; }
    }
}
