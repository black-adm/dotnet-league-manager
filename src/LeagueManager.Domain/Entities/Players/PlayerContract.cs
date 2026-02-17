using LeagueManager.Domain.Interfaces;

namespace LeagueManager.Domain.Players;

public sealed record PlayerContract(
    Guid ClubId,
    DateTime? StartDate,
    DateTime? EndDate,
    int SalaryPerMonth) : IValueObject;
