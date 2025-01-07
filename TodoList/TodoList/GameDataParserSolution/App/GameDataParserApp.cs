
using GameDataParserSolution.DataAccess;
using GameDataParserSolution.UserInteraction;

namespace GameDataParserSolution.App
{
    public class GameDataParserApp()
    {
        private readonly IUserInteractor _userInteractor;
        private readonly IGamesPrinter _gamesPrinter;
        private readonly IVideoGameDeserializer _videoGameDeserializer;
        private readonly IFileReader _reader;

        public GameDataParserApp(IUserInteractor userInteractor, IGamesPrinter gamesPrinter, IVideoGameDeserializer videoGameDeserializer, IFileReader filereader) : this()
        {
            _userInteractor = userInteractor;
            _gamesPrinter = gamesPrinter;
            _videoGameDeserializer = videoGameDeserializer;
            _reader = filereader;
        }
        public void Run()
        {
            string fileName = _userInteractor.ReadValidFilePath();
            var fileContents = _reader.Read(fileName);
            var videoGames = _videoGameDeserializer.DeserializeFrom(fileName, fileContents);
            _gamesPrinter.Print(videoGames);

        }






    }
}

