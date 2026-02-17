namespace LeagueManager.Application.UseCases.Clubs.Queries;

public sealed record GetAllClubsDto(
    Guid ClubId,
    string Name,
    string PhotoUrl,
    string WebsiteUrl);
