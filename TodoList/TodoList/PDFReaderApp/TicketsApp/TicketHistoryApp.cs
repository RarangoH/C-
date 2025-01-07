using System.Text;

public class TicketHistoryApp
{
    public readonly string _folderPath;
    public readonly FileHandler _fileHandler;
    public readonly TextAnalysis _textAnalysis;
    
    public TicketHistoryApp(FileHandler fileHandler, TextAnalysis textAnalysis)
    {
        _fileHandler = fileHandler;
        _folderPath = "C:\\Users\\rafaa\\Desktop\\Orden_Desorden\\Csharp\\C#\\TodoList\\TodoList\\PDFReaderApp\\Tickets";
        _textAnalysis = textAnalysis;

    }
    public void Run()
    {
        var sb = new StringBuilder();
        ///returns number of files
       

        ///iterates each file and extracts the information from each file
        
            
            var wordPerFile = _fileHandler.readPDF(_folderPath);


            foreach(var word in wordPerFile)
            {
            var wordsToPrint = _textAnalysis.wordSelector(word);
                sb.AppendLine(
                    string.Join(Environment.NewLine, wordsToPrint));


            }

            _fileHandler.SaveToFile(sb.ToString());
            
            
            Console.ReadKey();
        



        //Console.WriteLine(words);


    }
}

