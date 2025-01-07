


using GameDataParserSolution.UserInteraction;
using GameDataParserSolution.DataAccess;
using System.Text.Json;

namespace GameDataParserApp.DataAccess
{
    public class VideoGameDeserializer : IVideoGameDeserializer
    {
        private readonly IUserInteractor _userInteractor;

        public VideoGameDeserializer(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public List<VideoGame> DeserializeFrom(string fileName, string fileContents)
        {

            //If invalid JSON format passed throws exception
            try
            {
                return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
            }
            catch (JsonException ex)
            {
                _userInteractor.PrintError($"JSON in {fileName} file was not" + $"in a valid format.JSON body:");
                _userInteractor.PrintError(fileContents);

                throw new JsonException($"{ex.Message} The file is: {fileName}", ex);

            }


        }
    }

}
