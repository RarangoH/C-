using StarWarsApiAssignment.Model;
using StarWarsApiAssignment.UserInteraction;

namespace StarWarsApiAssignment.App
{
    public class PlanetsStatisticsAnalyzer : IStatisticsAnalyzer
    {
        private readonly IPlanetsStatsUserInteractor _planetsStatsUserInteractor;

        public PlanetsStatisticsAnalyzer(IPlanetsStatsUserInteractor planetsStatsUserInteractor)
        {
            _planetsStatsUserInteractor = planetsStatsUserInteractor;
        }
        private readonly Dictionary<string, Func<Planet, long?>> _propertyNamesToSelectorMapping = new()
        {
            ["population"] = planet => planet.Population,
            ["diameter"] = planet => planet.Diameter,
            ["surface water"] = planet => planet.SurfaceWater,
        };

        public void Analyze(IEnumerable<Planet> planets)
        {
            
            

            var userChoice = _planetsStatsUserInteractor.ChooseStatisticsToBeShown(_propertyNamesToSelectorMapping.Keys);

            if (userChoice is null || !_propertyNamesToSelectorMapping.ContainsKey(userChoice))
            {
                _planetsStatsUserInteractor.ShowMessage("Invalid choice");
            }
            else
            {
                ShowStatistics(planets, userChoice, _propertyNamesToSelectorMapping[userChoice]);

            }

        }
        private void ShowStatistics(IEnumerable<Planet> planets, string propertyName, Func<Planet, long?> propertySelector)
        {
            ShowStatistics(
                "Max",
                planets.MaxBy(propertySelector),
                propertySelector,
                propertyName);

            ShowStatistics(
                "Min",
                planets.MinBy(propertySelector),
                propertySelector,
                propertyName);

        }

        private void ShowStatistics(string descriptor, Planet selectedPlanet, Func<Planet, long?> propertySelector, string propertyName)
        {
            _planetsStatsUserInteractor.ShowMessage($"{descriptor} {propertyName} is: " +
                $"{propertySelector(selectedPlanet)} " +
                $"(planet: {selectedPlanet.Name})");
        }
    }
}
