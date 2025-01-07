

//var pairofInts = new Pair<int>(1, 2);

//Console.WriteLine("First:"+pairofInts.First);
//Console.WriteLine("Second:" + pairofInts.Second);
//pairofInts.ResetFirst();
//Console.ReadKey();
//public class Pair<T>
//{
//    public T First { get; private set; }
//    public T Second { get; private set;  }

//    public Pair(T first, T second)
//    {
//        First = first;
//        Second = second;
//    }
//    public void ResetFirst()
//    {
//        First = default(T);
//    }
//    public void ResetSecond()
//    {
//        Second = default(T);
//    }
//}

var i = new Tuple<int, string>(1, "hello");
Console.WriteLine(i);
Console.WriteLine(i.SwapTupleItems());
Console.ReadKey();
public static class Extension
{
    public static Tuple<T2, T1> SwapTupleItems<T1, T2>(this Tuple<T1,T2> tuple)
    {

        return new Tuple<T2, T1>(tuple.Item2, tuple.Item1);
    }
}