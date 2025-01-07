


using StarWarsApiAssignment;
using StarWarsApiAssignment.ApiDataAccess;
using StarWarsApiAssignment.DTOs;
using StarWarsApiAssignment.App;
using StarWarsApiAssignment.DataAccess;
using StarWarsApiAssignment.Model;
using StarWarsApiAssignment.UserInteraction;


try
{
    var consoleUserInteractor = new ConsoleUserInteractor();
    var planetsStatsUserInteractor =
        new PlanetsStatsUserInteractor(
                consoleUserInteractor);

    await new StarWarsPlanet(
        new PlanetsFromApiReader(
            new MockStarWarsApiDataReader(),
            new MockStarWarsApiDataReader(),
            consoleUserInteractor),
        new PlanetsStatisticsAnalyzer(
            planetsStatsUserInteractor),
        planetsStatsUserInteractor).Run();
    Console.ReadKey();
}
catch (Exception ex)
{

    Console.WriteLine("An error ocurred"+
           "Exception message: " + ex.Message);
}

