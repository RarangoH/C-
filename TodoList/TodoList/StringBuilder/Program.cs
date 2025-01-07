using System.Text;



var answ = StringBuilderExercise.Reverse("Carlos");
Console.WriteLine(answ);
Console.ReadKey();
public static class StringBuilderExercise
{
    public static string Reverse(string input)
    {
        var sb = new StringBuilder();
        for(int i = input.Length-1 ; i>= 0; i--)
        {
            sb.Append(input[i]);
        }
        return sb.ToString();

    }
}