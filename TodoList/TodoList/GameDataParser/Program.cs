

using System.Text.Json;

//Main Workflow of the App

//Prints a message when it starts

//var GameDataApp = new GameDataApp();


//Data Handling
//File connection

//Run method
//Method that savesValidFileName to string variable

var GameDataApp = new GameDataApp(new GameConsoleUserInteraction(),new JsonDataRepository());

GameDataApp.Run();
Console.ReadKey();  
public class GameDataApp
{
    private readonly IGameUserInteraction _gameUserInteraction;
    private readonly IDataAcces _dataAccessRepo;
    public GameDataApp(IGameUserInteraction gameUserInteraction, IDataAcces dataAccessRepo)
    {
        _gameUserInteraction = gameUserInteraction;
        _dataAccessRepo = dataAccessRepo; 
    }
    public void Run()
    {
        _gameUserInteraction.PrintInitialMessage();
        string connection = _gameUserInteraction.ReadInput();
        
        var info = _dataAccessRepo.Read(connection);
        _gameUserInteraction.PrintVideoGames(info);


         

    }
}

public class GameConsoleUserInteraction : IGameUserInteraction
{
    public void PrintInitialMessage()
    {
        Console.WriteLine("Enter the name of the file you want to read");
    }

    public void PrintVideoGames(List<Game> games)
    {
        if(games.Count == 0)
        {
            Console.WriteLine("No games are presnt in the input file.");
        }

        Console.WriteLine("Loaded games are: ");
        foreach (var game in games)
        {
            Console.WriteLine($"Title: {game.Title}, Year: {game.ReleaseYear}, Rating: {game.Rating}");
        }
        Console.ReadKey();
    }

    public string ReadInput()
    {
        string filePath = Console.ReadLine();
        int counter = 0;
        try
        {
            while (!File.Exists(filePath) && counter < 4)
            {
                Console.WriteLine("FilePath Invalid, Please enter again");
                filePath = Console.ReadLine();
                counter++;
            }
            return filePath;
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Null value passed as parameter", ex.Message);
            return "null";
        }
        //Commented B/C I think this should go into the DataAccessRepository that handles files
        //try
        //{
        //    bool isFilePath = false;
        //    string filepath;
        //    int counter = 0;
        //    while (!isFilePath && counter < 4)
        //    {
        //        filepath = Console.ReadLine();
        //        if (filepath is not null && File.Exists(filepath))
        //        {

        //            isFilePath = true;
        //            return filepath;

        //        }
        //        counter++;
        //    }
        //    return "null";
        //}
        //catch (ArgumentNullException ex)
        //{
        //    Console.WriteLine("Null value passed as parameter",ex.Message);
        //    return "null";  
        //}
    }


    public void ShowMessage(string message)
    {
        throw new NotImplementedException();
    }
}
public interface IGameUserInteraction
{
    void PrintInitialMessage();
    void ShowMessage(string message);

    string ReadInput();

    void PrintVideoGames(List<Game> games);
}

//DataAccess

public interface IDataAcces
{
    List<Game> Read(string connectionRoute);
    void Write(string connectionRoute);
}

public abstract class DataAccessRepository : IDataAcces
{
    public List<Game> Read(string connectionRoute)
    {
        if (File.Exists(connectionRoute))
        {
            var fileConents = File.ReadAllText(connectionRoute);
            return TextToStrings(fileConents);  
        }
        return new List<Game>();
    }

    //Method to Deserialize Data
    protected abstract List<Game> TextToStrings(string fileContents);
    //Method to Serialize Data
    protected abstract string StringsToText(List<string> strings);

    public void Write(string connectionRoute)
    {
        throw new NotImplementedException();
    }
}

public class JsonDataRepository : DataAccessRepository
{
    protected override string StringsToText(List<string> strings)
    {
        return JsonSerializer.Serialize(strings);
    }

    protected override List<Game> TextToStrings(string fileContents)
    {
        try
        {
            return JsonSerializer.Deserialize<List<Game>>(fileContents);
        }
        catch (Exception ex)
        {

            Console.WriteLine("JSON Format Not Valid",ex);
            throw ex;
        }
        
    }
}

public class Game
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public double Rating { get; set; }
}