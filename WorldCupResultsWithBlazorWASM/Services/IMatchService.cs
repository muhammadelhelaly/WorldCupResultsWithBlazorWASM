using WorldCupResultsWithBlazorWASM.Dtos;

namespace WorldCupResultsWithBlazorWASM.Services;

public interface IMatchService
{
    Task<StandingsResponseDto?> GetStandings();
    Task<MatchesResponseDto?> GetTodayMatches();
}