﻿using StarWarsApiAssignment.Model;

namespace StarWarsApiAssignment.UserInteraction
{
    public interface IPlanetsStatsUserInteractor
    {
        void Show(IEnumerable<Planet> planets);
        string? ChooseStatisticsToBeShown(IEnumerable<string> propertiesThatCanBeChosen);
        void ShowMessage(string message);
    }
}
