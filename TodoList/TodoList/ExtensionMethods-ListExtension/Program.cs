


public static class Seconds{
    public static List<int> TakeEverySecond(this List<int> initial) 
    {
        List<int> result = new List<int>();
        if (initial.Count != 0)
        {
            int i = 0;
           
            foreach (var x in initial)
            {
                i++;
                if ((i % 2) != 0)
                {
                    result.Add(x);
                }
            }
            return result;
        }
        else
        {
            return result;
        }
        
    }
}