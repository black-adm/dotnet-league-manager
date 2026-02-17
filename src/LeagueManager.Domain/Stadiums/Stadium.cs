using LeagueManager.Domain.Common;
using LeagueManager.Domain.Interfaces;

namespace LeagueManager.Domain.Stadiums;

public class Stadium : BaseEntity, IAggregateRoot
{
    public string Name { get; private set; } = string.Empty;

    public int? Capacity { get; private set; }

    public int? BuiltYear { get; private set; }

    public int? PitchLength { get; private set; }

    public int? PitchWidth { get; private set; }

    public string PhotoUrl { get; private set; } = string.Empty;

    public bool? IsDeleted { get; private set; }

    public Address Address { get; private set; }
}
