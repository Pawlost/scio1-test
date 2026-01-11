namespace Scio1.DAL.Entities;

public record MeetingEntity : EntityBase
{
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset End { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
}
