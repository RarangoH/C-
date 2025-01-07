using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWarsApiAssignment.DataAccess;
using StarWarsApiAssignment.UserInteraction;

namespace StarWarsApiAssignment.App
{
    class StarWarsPlanet
    {

        private readonly IPlanetsReader _planetsReader;
        private readonly IStatisticsAnalyzer _planetsStatisticsAnalyzer;
        private readonly IPlanetsStatsUserInteractor _planetsStatsUserInteractor;

        public StarWarsPlanet(IPlanetsReader planetsReader, IStatisticsAnalyzer planetsStatisctiscAnalyzer, IPlanetsStatsUserInteractor planetsStatsUserInteractor)
        {
            _planetsReader = planetsReader;
            _planetsStatisticsAnalyzer = planetsStatisctiscAnalyzer;
            _planetsStatsUserInteractor = planetsStatsUserInteractor;
        }
        public async Task Run()
        {
            var planets = await _planetsReader.Read();
            _planetsStatsUserInteractor.Show(planets);
            _planetsStatisticsAnalyzer.Analyze(planets);



        }

    }
}
