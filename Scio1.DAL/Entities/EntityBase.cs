namespace Scio1.DAL.Entities;

public abstract record EntityBase
{
    public required Guid Id { get; init; }
}
