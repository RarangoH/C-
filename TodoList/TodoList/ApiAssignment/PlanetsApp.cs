

using System.Text.Json;
using planets.DTOs;

namespace planets;

    public class PlanetsApp
    {
    
    public readonly IBusinessLogic _businessLogic;
    public readonly IRepository _repository;
    public readonly IConditionValidator _conditionValidator;

        public PlanetsApp(IRepository data, IBusinessLogic businesslogic, IConditionValidator conditionValidator)
        {
            _repository = data;
            _businessLogic = businesslogic;
        _conditionValidator = conditionValidator;
        }

    public async void Run()
    {
        string data = await _repository.Read("https://swapi.dev/", "api/planets");
        var dataPlanets = JsonSerializer.Deserialize<Root>(data);
        
       

        DataPrinter.PrintData(dataPlanets.results);

        

        
        (string,string) output = _conditionValidator.Validate(dataPlanets.results);
        Console.WriteLine(output);

    }

        
    }


