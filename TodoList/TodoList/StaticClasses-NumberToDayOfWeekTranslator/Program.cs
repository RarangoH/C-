﻿


var tuesday = NumberToDayOfWeekTranslator.Translate(2);
Console.WriteLine(tuesday);
Console.ReadKey();  
public static class NumberToDayOfWeekTranslator
{
    public static string Translate(int value)
    {
        switch(value)
        {
            case 1:
                return "Monday";
            case 2:
                return "Tuesday";
            case 3:
                return "Wednesday";
            case 4:
                return "Thursday";
            case 5:
                return "Friday";
            case 6:
                return "Saturday";
            case 7:
                return "Sunday";
            default:
                return "Invalid day of the week";
        }
      

    }


}