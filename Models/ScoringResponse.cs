namespace DmsScoring.Models
{
    public class ScoringResponse
    {
        public List<GroupSummary> GroupSummaries { get; set; }
        public double TotalFinalScore { get; set; }
        public string RiskCategory { get; set; }
    }

}
