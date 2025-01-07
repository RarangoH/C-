

Exercise n1 = new Exercise();
List<string> w = new List<string>{ "bobcat", "wolverine", "grizzly" };
Console.WriteLine(n1.ProcessAll(w)); 
Console.ReadKey();
public class Exercise
{
    public List<string> ProcessAll(List<string> words)
    {
        var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

        List<string> result = words;
        foreach (var stringsProcessor in stringsProcessors)
        {
            result = stringsProcessor.Process(result);
        }
        return result;
    }

    
}
public class StringsProcessor
{
    public List<string> Process(List<string> strings)
    {
        var result = new List<string>();
        foreach (var text in strings)
        {
            result.Add(ProcessSingle(text));
        }
        return result;
    }
    protected virtual string ProcessSingle(string input) => input;
}
public class StringsTrimmingProcessor : StringsProcessor
{
    protected override string ProcessSingle(string input) =>
        input.Substring(0, input.Length / 2);
}

public class StringsUppercaseProcessor : StringsProcessor
{
    protected override string ProcessSingle(string input) =>
        input.ToUpper();
}
