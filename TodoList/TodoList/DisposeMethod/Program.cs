public class AllLinesFromTextFileReader : IDisposable
{
    private readonly StreamReader _streamReader;

    public AllLinesFromTextFileReader(string filePath)
    {
        _streamReader =  new StreamReader(filePath);
        }

    

    public List<string> ReadAllLines()
    {
        var result = new List<string>();
        while (!_streamReader.EndOfStream)
        {
            result.Add(_streamReader.ReadLine());
        }

        return result;
    }

    public void Dispose()
    {
        _streamReader.Dispose();
    }
}




public class CsvReader
{
    public CsvData Read(string path)
    {
        using var streamReader = new StreamReader(path);


        const string Separator = ",";
        var columns = streamReader.ReadLine().Split(Separator);
        
        var rows = new List<string[]>();
        while (!streamReader.EndOfStream)
        {
            var cellsInRow = streamReader.ReadLine().Split(Separator);
            rows.Add(cellsInRow);
        }
        return new CsvData(columns, rows);
    }
}

public class CsvData
{
    public string[] Columns { get; }
    public IEnumerable<string[]> Rows { get; }  

    public CsvData(string[] columns, IEnumerable<string[]> rows)
    {
        Columns = columns;
        Rows = rows;
    }

}