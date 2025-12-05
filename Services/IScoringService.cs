using DmsScoring.Models;

namespace DmsScoring.Services
{
    public interface IScoringService
    {
        ScoringResponse Calculate(ScoringRequest request);
    }

}
