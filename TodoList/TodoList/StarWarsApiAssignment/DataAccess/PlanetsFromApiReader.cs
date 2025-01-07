﻿using StarWarsApiAssignment.ApiDataAccess;
using System.Text.Json;

using StarWarsApiAssignment.DataAccess;
using StarWarsApiAssignment.DTOs;
using StarWarsApiAssignment.Model;
using StarWarsApiAssignment.UserInteraction;

namespace StarWarsApiAssignment.DataAccess
{
    public class PlanetsFromApiReader : IPlanetsReader
    {

        private readonly IApiDataReader _apiDataReader;
        private readonly IApiDataReader _secondaryDataReader;
        private readonly IUserInteractor _userInteractor;

        public PlanetsFromApiReader(IApiDataReader apiDataReader, IApiDataReader secondaryDataReader, IUserInteractor userInteractor)
        {
            _apiDataReader = apiDataReader;
            _secondaryDataReader = secondaryDataReader;
            _userInteractor = userInteractor;
        }
        public async Task<IEnumerable<Planet>> Read()
        {
            string? json = null;

            try
            {

                json = await _apiDataReader.Read("https://swapi.dev/", "api/planets");
                

               

            }
            catch (HttpRequestException ex)
            {

                _userInteractor.ShowMessage("API request was unsuccessful" + "Switching to mock data. " + "Exception message" + ex.Message);
                
            }
            json ??= await _secondaryDataReader.Read("https://swapi.dev/", "api/planets");
            var root = JsonSerializer.Deserialize<Root> (json);
            return ToPlanets(root);
        }
        private static IEnumerable<Planet> ToPlanets(Root? root)
        {
            if (root is null)
            {
                throw new ArgumentNullException(nameof(root));
            }

            return root.results.Select(planetDto => (Planet)planetDto);


        }
    }
}
