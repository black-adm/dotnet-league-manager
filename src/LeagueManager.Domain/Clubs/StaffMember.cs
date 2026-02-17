using LeagueManager.Domain.Interfaces;

namespace LeagueManager.Domain.Clubs;

public class StaffMember : BaseEntity, IAggregateRoot
{
    public string FullName { get; private set; } = string.Empty;

    public Club Club { get; private set; }

    public StaffRole Role { get; private set; }
}
