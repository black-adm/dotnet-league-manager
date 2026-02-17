namespace LeagueManager.Domain.Interfaces;

public abstract class IBaseEntity : IEntity
{
    public Guid Id { get; set; }
}
