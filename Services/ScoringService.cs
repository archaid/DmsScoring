using DmsScoring.Domain;
using DmsScoring.Models;

namespace DmsScoring.Services
{
    public class ScoringService : IScoringService
    {
        public ScoringResponse Calculate(ScoringRequest request)
        {
            var rows = request.Rows;

            // Group per GroupName
            var groupResult = rows
                .GroupBy(r => r.Group)
                .Select(g =>
                {
                    double totalFD = g.Sum(r => r.BobotF * (r.BobotD / 100));
                    double bobotB = g.First().BobotB;
                    double finalScore = totalFD * (bobotB / 100);

                    return new GroupSummary
                    {
                        Group = g.Key,
                        TotalFD = totalFD,
                        BobotB = bobotB,
                        FinalScore = finalScore
                    };
                })
                .ToList();

            double totalFinal = groupResult.Sum(x => x.FinalScore);
            string risk = ScoringCalculator.GetRisk(totalFinal);

            return new ScoringResponse
            {
                GroupSummaries = groupResult,
                TotalFinalScore = totalFinal,
                RiskCategory = risk
            };
        }
    }

}
