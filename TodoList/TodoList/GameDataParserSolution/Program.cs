using GameDataParserApp.App;
using GameDataParserApp.DataAccess;
using GameDataParserApp.Logging;
using GameDataParserApp.UserInteraction;

var userInteractor = new ConsoleUserInteractor();
var app = new GameDataParserApp(userInteractor, new GamesPrinter(userInteractor), new VideoGameDeserializer(userInteractor), new LocalFileReader());
var logger = new Logger("log.txt");
try
{
    app.Run();
}
catch (Exception ex)
{

    Console.WriteLine("Sorry! The application has experienced an unexpected error");
    logger.Log(ex); 
}
Console.WriteLine("Press any key to close.");
Console.ReadKey();
