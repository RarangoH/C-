using planets.DTOs;
namespace planets
{
    public interface IConditionValidator
    {
        (string,string) Validate( IReadOnlyList<Planet> planets);
    }
}