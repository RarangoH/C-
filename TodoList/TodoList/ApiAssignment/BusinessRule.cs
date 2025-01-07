
using planets.DTOs;
namespace planets
{
    

    
    public class BusinessRule : IBusinessLogic
    {
        public readonly IRepository _repository;
       
        public readonly IReadOnlyList<Planet> _planets;

        public BusinessRule()
        {
            

        }
       
        public (string, string) CalculatePopulation(IReadOnlyList<Planet> planets)
        {
            //se debe validar que los planetas no sean nulos
            var lg = planets[0];
            var min = planets[0];
            foreach (var planet in planets)
            {
                

                if (Int64.Parse(planet.population) > Int64.Parse(lg.population))
                {
                    lg = planet;
                }
                if (Int64.Parse(planet.population) < Int64.Parse(min.population))
                {
                    min = planet;
                }
            }
            return ($"Max Population is {lg.population }(planet:{lg.name})", $"Max Population is {min.population}(planet:{min.name})");
        }
        public (string, string) CalculateDiameter(IReadOnlyList<Planet> planets)
        {//se debe validar que los planetas no sean nulos
            var lg = planets[0];
            var min = planets[0];
            foreach (var planet in planets)
            {


                if (Int64.Parse(planet.diameter) > Int64.Parse(lg.diameter))
                {
                    lg = planet;
                }
                if (Int64.Parse(planet.diameter) < Int64.Parse(min.diameter))
                {
                    min = planet;
                }
            }
            return ($"Max Diameter is {lg.diameter}(planet:{lg.name})", $"Max Diameter is {min.diameter}(planet:{min.name})");

        }
        public (string, string) CalculateSW(IReadOnlyList<Planet> planets)
        {
            //se debe validar que los planetas no sean nulos
            var lg = planets[0];
            var min = planets[0];
            foreach (var planet in planets)
            {


                if (Int64.Parse(planet.surface_water) > Int64.Parse(lg.surface_water))
                {
                    lg = planet;
                }
                if (Int64.Parse(planet.surface_water) < Int64.Parse(min.surface_water))
                {
                    min = planet;
                }
            }
            return ($"Max Surface Water is {lg.surface_water}(planet:{lg.name})", $"Max Surface Water is {min.surface_water}(planet:{min.name})");

        }
    }

}