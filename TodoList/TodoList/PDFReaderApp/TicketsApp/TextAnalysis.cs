using System.Globalization;
//word analyzer

// word to Text

public class TextAnalysis : ITextAnalysis
    {
    private readonly Dictionary<string, CultureInfo> _fileTypeToCultureMapping = new()
    {
        ["com"] = new CultureInfo("en-US"),
        ["fr"] = new CultureInfo("fr-FR"),
        ["jp"] = new CultureInfo("ja-JP"),
    };

    public IEnumerable<string> wordSelector(string textOfWords)
        {
        
        var words = textOfWords.Split(new[] { "Title:", "Date:", "Time:", "Visit us:" },StringSplitOptions.None).ToList();
        var domain = getFileType(words.Last());
        foreach (var word in _fileTypeToCultureMapping)
        {
            Console.WriteLine(word);
        }

        for(int i = 1; i<words.Count-3; i +=3 )
        {
            var titles = words[i];
            var dates = words[i+1];
            var times = words[i+2];
            yield return BuildTicketData(titles,dates,times,domain);
        }

        
        

        
    
        }
        public string getFileType(string fileName)
        {
            var fileExtension = fileName.Split('.').Last();
        return fileExtension;
        }

        public string BuildTicketData(string title, string date, string time, string domain)
        {
        var newDate = DateOnly.Parse(date, _fileTypeToCultureMapping[domain]);
        var newTime = TimeOnly.Parse(time, _fileTypeToCultureMapping[domain]);
        var ticketData = $"{title,-40}|{newDate}|{newTime}";
            return ticketData;
        }
}

