using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Threading;

void GetOnlyUpperCaseWords(List<string> words)
{
    List<string> result = new List<string>(words);
    for (int i = 0; i < words.Count; i++)
    {
        foreach (char let in words[i])
        {
            if (!(char.IsUpper(let)) || char.IsDigit(let))
            {
                result.Remove(words[i]);
                break;
            }


        }

    }
    var count = 0;
    for (int i = 0; i < result.Count; i++)
    {
        count = 0;
        for (int j = 0; j < result.Count; j++)
        {

            if (result[i].Equals(result[j]))
            {
                count++;

            }
            if (count >= 2)
            {
                result.RemoveAt(j);

            }
        }

    }

    // var s = result.Where(x => x.Equals("CARLOS")).Count();

    //Console.WriteLine("Index of Carlos"+s);
    foreach (var word in result)
    {
        Console.WriteLine(word);
    }

}
List<string> names = new List<string> { "one", "TWO", "THREE", "four", "TWO", "FIVE" };
GetOnlyUpperCaseWords(names);
Console.WriteLine(names);
Console.Read();