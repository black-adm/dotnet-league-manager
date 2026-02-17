using LeagueManager.Domain.Interfaces;

namespace LeagueManager.Domain.Entities.Clubs;

public sealed record SocialLinks(
    string FacebookUrl,
    string TwitterUrl,
    string InstagramUrl,
    string YoutubeUrl) : IValueObject;
