using LeagueManager.Domain.Interfaces;

namespace LeagueManager.Domain.Players;

public sealed class Player : IBaseEntity, IAggregateRoot
{
    public string Name { get; private set; } = string.Empty;

    public int? ShirtNo { get; private set; }

    public DateTime? BithDate { get; private set; }

    public int? HeightInCm { get; private set; }

    public string PhotoUrl { get; private set; } = string.Empty;

    public string WebsiteUrl { get; private set; } = string.Empty;

    public bool? IsDeleted { get; private set; }

    public PlayerPosition Position { get; private set; }

    public PlayerStats Stats { get; private set; }

    public PlayerContract Contract { get; private set; }
}
