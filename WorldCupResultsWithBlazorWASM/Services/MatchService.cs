using System.Net.Http.Json;
using WorldCupResultsWithBlazorWASM.Dtos;

namespace WorldCupResultsWithBlazorWASM.Services;

public class MatchService : IMatchService
{
    private readonly HttpClient _http;
    private readonly string _baseUrl = "https://api.football-data.org/v4";

    public MatchService(HttpClient http)
    {
        _http = http;
        _http.DefaultRequestHeaders.Add("X-Auth-Token", "Add Your Own");
    }

    public async Task<StandingsResponseDto?> GetStandings()
    {
        return await _http.GetFromJsonAsync<StandingsResponseDto>($"{_baseUrl}//competitions/WC/standings");
    }

    public async Task<MatchesResponseDto?> GetTodayMatches()
    {
        var date = DateTime.Today.ToString("yyyy-MM-dd");
        return await _http.GetFromJsonAsync<MatchesResponseDto>($"{_baseUrl}//competitions/WC/matches?dateFrom={date}&dateTo={date}");
    }
}