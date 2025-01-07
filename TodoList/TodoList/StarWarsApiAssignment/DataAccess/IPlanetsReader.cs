using StarWarsApiAssignment.Model;

namespace StarWarsApiAssignment.DataAccess
{
    public interface IPlanetsReader
    {
        public Task<IEnumerable<Planet>> Read();
    }
}
