public interface IFileHandler
{
    IEnumerable<string> readPDF(string fileName);
    //string[] getFiles(string folderPath);
    void SaveToFile(string text);
}

