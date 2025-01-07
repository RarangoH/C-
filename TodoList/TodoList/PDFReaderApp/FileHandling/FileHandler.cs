using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

public class FileHandler : IFileHandler
{
    public readonly string _textFilePath = "C:\\Users\\rafaa\\Desktop\\Orden_Desorden\\Csharp\\C#\\TodoList\\TodoList\\PDFReaderApp\\";
    //public string[] getFiles(string folderPath)
    //{
    //    var fileNames = Directory.GetFiles(folderPath);
    //    return fileNames;
    //}
    public void ReadFolder(string folderPath)
    {

    }
    //public readonly IEnumerable<Word> _words;

    public IEnumerable<string> readPDF(string folderPath)
    {

        //Dictionary<int, IEnumerable<Word>> wordsPerPage = new Dictionary<int, IEnumerable<Word>>();
        foreach (var filePath in Directory.GetFiles(folderPath))
        {
            using (PdfDocument document = PdfDocument.Open(filePath))
            {

                //int counter = 0;

                if (document is not null)
                {
                    foreach (Page page in document.GetPages())
                    {
                        //string pageText = page.Text;

                        //IEnumerable<Word> words = page.GetWords();
                        //wordsPerPage[counter] = words;
                        //counter++;

                        yield return page.Text;
                    }
                }
                else
                {
                    throw new ArgumentNullException();
                }



            }
        }
        
    }

    public void SaveToFile(string text)
    {
        //"{0,-40}{1,-15}{2,-20}"
        //using (StreamWriter writer = new StreamWriter(_textFilePath))
        //{
            
        //    writer.WriteLine(text);
        //}
        var resultPath = Path.Combine(_textFilePath, "FileToSave.txt");
        File.WriteAllText(resultPath, text);
        Console.WriteLine("Results savd to " + resultPath);
    }

    
}

