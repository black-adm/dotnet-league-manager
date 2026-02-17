namespace LeagueManager.Domain.Interfaces;

public abstract class BaseEntity : IEntity
{
    public Guid Id { get; set; }
}
