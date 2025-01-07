DateTime tt = new DateTime(2000, 05, 23);

RefModifierFastForwardToSummerExercise.FastForwardToSummer(ref tt);

public static class RefModifierFastForwardToSummerExercise
{
    public static void FastForwardToSummer(ref DateTime obj)
    {
        var date = new DateTime(obj.Year, 06, 21);
        if(!(obj > date))
        {
            obj = date;
        }
    }
}