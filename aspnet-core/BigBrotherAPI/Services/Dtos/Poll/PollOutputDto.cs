namespace BigBrotherAPI.Services.Dtos.Poll
{
    public class PollOutputDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public DateTime ClosureTime { get; set; }
    }
}
