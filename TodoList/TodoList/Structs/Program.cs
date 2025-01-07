
var t1 = new Time(2, 60);


public struct Time
{
    public int Hour { get; }     
    public int Minute { get; }

    public Time(int hour, int minute)
    {
        
        if ((hour < 0 || hour > 23) || (minute < 0 || minute > 59))
        {

            throw new ArgumentOutOfRangeException();
        }
        Hour = hour;
        Minute = minute;    
    }

    public override string ToString()
    {
        if(Hour < 10)
        {
            if (Minute < 10)
                return $"0{Hour}:0{Minute}";
            else
                return $"0{Hour}:{Minute}";
        }
            
            
        if (Minute < 10)
            return $"{Hour}:0{Minute}";
        return $"{Hour}:{Minute}";

    }
}
