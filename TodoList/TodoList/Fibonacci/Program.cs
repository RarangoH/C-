


var numbersList = CheckedFibonacciExercise.GetFibonacci(48);
foreach (var number in numbersList)
{
    Console.WriteLine(number);
}
Console.ReadKey();

public static class CheckedFibonacciExercise
{
    public static IEnumerable<int> GetFibonacci(int n)
    {
        checked
        {
            int first = 0;
            int second = 1;
            List<int> numbers = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    numbers.Add(first);
                    yield return first;
                }
                else if (i == 1)
                {
                    numbers.Add(second);
                    yield return second;
                }
                else
                {
                    int sum = (numbers[i - 2] + numbers[i - 1]);
                    numbers.Add(sum);
                    yield return sum;

                }
            }
        }
        
       
    }
}