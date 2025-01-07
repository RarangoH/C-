using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using planets.DTOs;
namespace planets
{
    
    class ConditionValidator : IConditionValidator
    {
        public readonly IBusinessLogic _businesslogic;
        
        int counter = 0;
        public ConditionValidator(IBusinessLogic businessLogic)
        {
            _businesslogic = businessLogic;
        }
        public (string,string) Validate( IReadOnlyList<Planet> planets)
        {
            bool value = false;
            while (!value && counter < 5)
            {
                Console.WriteLine("Enter a value");
                string userInput = Console.ReadLine();
                if (userInput != null)
                {
                    if (userInput == "population")
                    {
                        value = true;
                        return _businesslogic.CalculatePopulation(planets);


                    }
                    else if (userInput == "diameter")
                    {
                        value = true;
                        return _businesslogic.CalculateDiameter(planets);
                    }
                    else if (userInput == "surface water")
                    {
                        value = true;
                        return _businesslogic.CalculateSW(planets);
                    }
                }
                counter++;
            }
          throw new NotImplementedException();
        }
    }
}
