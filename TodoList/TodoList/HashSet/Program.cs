
List<string> s = new List<string> {"a","b",null,"d","e","f" };



foreach (var item in YieldExercise.GetAllAfterLastNullReversed(s))
{
    Console.WriteLine(item);
}

//var stack = new Stack<string>();
//var numbers = new int[] { 1, 2, 3, 4, 5 };



//stack.Push("wolf");
//stack.Push("cat");
//stack.Push("fox");

//var result = stack.DoesContainAny("deer", "mouse", "dog");

public static class HashSetsUnionExercise
{
    public static HashSet<T> CreateUnion<T>(
        HashSet<T> set1, HashSet<T> set2)
    {
        HashSet<T> union = new HashSet<T>(set1);
        union.UnionWith(set2);
        return union;
    }

    
}
public static class StackExtensions
{
    public static bool DoesContainAny(this Stack<string> input, params string[] words)
    {


        foreach (var word in words)
        {
            if (input.Contains(word))
            return true;
        }
        return false;
        

    }
}



public class YieldExercise
{
    public static IEnumerable<T> GetAllAfterLastNullReversed<T>(IList<T> input)
    {
        Stack<T> s = new Stack<T>(input);
        for (int i = input.Count-1; i >0; i--)
        {
            {
                if (input[i] != null)
                {
                    yield return s.Pop();

                }
                else
                {
                    yield break;
                }
            }

        }
    }
}