
IEnumerable<double> doubles = new List<double> { 2.2,2.2 };

var validation = FloatingPointNumbersExercise.IsAverageEqualTo(doubles, 4.4);
Console.ReadKey();
public static class FloatingPointNumbersExercise
{
    public static bool IsAverageEqualTo(
        this IEnumerable<double> input, double valueToBeChecked)
    {
        foreach (var number in input)
        {
            if (Double.IsInfinity(number) || Double.IsNaN(number))
                throw new ArgumentException();
        }
        
            double tolerance = 0.00001;
            var average = input.Average();
            if (isEqual(average, valueToBeChecked, tolerance))
            {
                return true;
            }
            else
                return false;
        
        
        
        
        
    }
    private static bool isEqual(double avg, double valueToBeChecked, double tolerance)
    {
        return Math.Abs(avg - valueToBeChecked) < tolerance;
    }
}