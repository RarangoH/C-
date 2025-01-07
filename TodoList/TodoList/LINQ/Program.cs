//LINQ

using System.Linq;

var testDates = new List<DateTime>
{
    new DateTime(2023, 1, 6),  // Friday
    new DateTime(2023, 1, 13), // Friday
    new DateTime(2023, 2, 3),  // Friday
    new DateTime(2023, 2, 4),  // Friday
    new DateTime(2023, 3, 17), // Friday
    new DateTime(2023, 3, 24), // Friday
    new DateTime(2023, 3, 25), // Saturday
    new DateTime(2024, 1, 5),  // Friday
    new DateTime(2024, 2, 2),  // Friday
    new DateTime(2024, 2, 16), // Friday
    new DateTime(2024, 3, 29), // Friday
    new DateTime(2025, 1, 3),  // Friday
    new DateTime(2025, 1, 10), // Friday
    new DateTime(2025, 1, 17), // Friday
    
};
var list = Exercise.GetFridaysOfYear(2023, testDates); 
foreach (var day in list)
{
    Console.WriteLine(day.ToShortDateString());
}
Console.ReadKey();
public class Exercise
{
    //check if there is word consisting of only white spaces in a list of words
    public static bool IsAnyWordWhiteSpace(List<string> words)
    {
        return words.Any(word => word.All(c => char.IsWhiteSpace(c)));
        }

    //Returns the count of the lists that meet the following conditions. 1. Contain the number zero, 2. Are longer than length
    public static int CountListsContainingZeroLongerThan(
           int length,
           List<List<int>> listsOfNumbers)
    {
        return listsOfNumbers.Count(number => number.Contains(0) && number.Count() > length);
    }

    //finds shorters words in a collection of strings if more than one words are the same minimal length the first one in order should be returned
    public static string FindShortestWord(List<string> words)
    {
        return words.OrderBy(word => word.Length).First();
    }

    //returns a collection of all dates from this collection that are fridays and are not repeated and are from a specified year passed as parameter
    public static IEnumerable<DateTime> GetFridaysOfYear(int year, IEnumerable<DateTime> dates)
    {
        return dates.Where(date => date.DayOfWeek == DayOfWeek.Friday && date.Year  == year).Distinct();
    }


    //takes collection of timeSpans (datatype) and returns their average duration in milliseconds
    public static double CalculateAverageDurationInMilliseconds(IEnumerable<TimeSpan> timeSpans)
    {
        return timeSpans.Average(span => span.TotalMilliseconds);
    }

}