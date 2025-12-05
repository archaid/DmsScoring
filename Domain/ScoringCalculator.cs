namespace DmsScoring.Domain
{
    public static class ScoringCalculator
    {
        public static string GetRisk(double totalScore)
        {
            if (totalScore <= 55)
                return "HIGH RISK";
            if (totalScore <= 70)
                return "MEDIUM RISK";
            return "LOW RISK";
        }
    }

}
