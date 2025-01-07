using planets.DTOs;
namespace planets
{
    public interface IBusinessLogic
    {
        (string, string) CalculatePopulation(IReadOnlyList<Planet> planets);
        (string, string) CalculateDiameter(IReadOnlyList<Planet> planets);
        (string, string) CalculateSW(IReadOnlyList<Planet> planets);
    }
}
