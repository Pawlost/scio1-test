namespace Scio1.BL.Models
{
    public class MeetingModel
    {
        public required Guid Id { get; init; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
    }
}
