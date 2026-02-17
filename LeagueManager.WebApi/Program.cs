using LeagueManager.Application;
using LeagueManager.Infrastructure;
using LeagueManager.Persistence;
using LeagueManager.Presentation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services
    .AddApplication()
    .AddInfrastructure()
    .AddPersistence()
    .AddPresentation();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
