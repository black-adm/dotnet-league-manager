using LeagueManager.Domain.Common;
using LeagueManager.Domain.Entities.Clubs;
using LeagueManager.Domain.Interfaces;
using LeagueManager.Domain.Players;
using LeagueManager.Domain.Stadiums;

namespace LeagueManager.Domain.Clubs;

public sealed class Club : IBaseEntity, IAggregateRoot
{
    public string Name { get; private set; } = string.Empty;

    public string PhotoUrl { get; private set; } = string.Empty;

    public int FoundedYear { get; private set; }

    public string WebsiteUrl { get; private set; } = string.Empty;

    public bool? IsDeleted { get; private set; }

    public SocialLinks Links { get; private set; }

    public Address Address { get; private set; }

    public List<Player> Players { get; private set; } = [];

    public List<StaffMember> StaffMembers { get; private set; } = [];

    public Stadium Stadium { get; private set; }

    private Club()
    {
    }

    private Club(
        string name,
        string photoUrl,
        int foundedYear,
        string websiteUrl)
    {
        Name = name;
        PhotoUrl = photoUrl;
        FoundedYear = foundedYear;
        WebsiteUrl = websiteUrl;
    }

    public static Club Create(
        string name,
        string photoUrl,
        int foundedYear,
        string websiteUrl)
    {
        return new Club(name, photoUrl, foundedYear, websiteUrl);
    }

    public void Update(string photoUrl, string websiteUrl)
    {
        PhotoUrl = photoUrl;
        WebsiteUrl = websiteUrl;
    }

    public void UpdateAddress(Address address) => Address = address;

    public void UpdateSocialLinks(SocialLinks links) => Links = links;

    public void MarkAsDeleted() => IsDeleted = true;

    public void AddPlayer(Player player) => Players.Add(player);

    public void RemovePlayer(Player player) => Players.Remove(player);
}
