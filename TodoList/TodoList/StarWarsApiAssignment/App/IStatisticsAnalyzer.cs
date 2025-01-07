using StarWarsApiAssignment.Model;

namespace StarWarsApiAssignment.App
{
    public interface IStatisticsAnalyzer
    {
        void Analyze(IEnumerable<Planet> planets);
    }
}
