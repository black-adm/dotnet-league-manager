using LeagueManager.Domain.Interfaces;

namespace LeagueManager.Domain.Players;

public sealed record PlayerStats(
    int Apperances,
    int Goals,
    int Assists) : IValueObject;
