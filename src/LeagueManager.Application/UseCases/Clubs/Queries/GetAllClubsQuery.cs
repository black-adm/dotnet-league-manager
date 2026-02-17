using LeagueManager.Application.Abstractions.Messaging;

namespace LeagueManager.Application.UseCases.Clubs.Queries;

public sealed record GetAllClubsQuery : IQuery<List<GetAllClubsDto>>
{
}
