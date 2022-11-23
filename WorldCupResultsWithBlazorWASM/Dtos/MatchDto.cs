namespace WorldCupResultsWithBlazorWASM.Dtos;

public class MatchDto
{
    public DateTime utcDate { get; set; }
    public string status { get; set; }
    public string stage { get; set; }
    public string group { get; set; }
    public TeamDto homeTeam { get; set; }
    public TeamDto awayTeam { get; set; }
    public ScroreDto score { get; set; }
}