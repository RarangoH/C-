



using System.Drawing;

public struct Time
{
    public int Hour { get; }
    public int Minute { get; }

    public Time(int hour, int minute)
    {
        if (hour < 0 || hour > 23)
        {
            throw new ArgumentOutOfRangeException(
                "Hour is out of range of 0-23");
        }
        if (minute < 0 || minute > 59)
        {
            throw new ArgumentOutOfRangeException(
                "Minute is out of range of 0-59");
        }
        Hour = hour;
        Minute = minute;
    }

    public override string ToString() =>
        $"{Hour.ToString("00")}:{Minute.ToString("00")}";

    public static bool operator ==(Time t1, Time t2) =>
        t1.Hour == t2.Hour && t1.Minute == t2.Minute;

    public static bool operator !=(Time t1, Time t2) =>
        !(t1 == t2);

    public static Time operator +(Time t1, Time t2)
    {
        var hour =  t1.Hour  + t2.Hour;
        var min = t1.Minute + t2.Minute;
        if (min > 59)
        {
            hour++;
            min -= 60;
        }
        return new Time(hour % 24, min);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Hour, Minute);
    }
    public override bool Equals(object obj)
    {
        return obj is Time other &&
            Hour == other.Hour &&
            Minute == other.Minute;
    }
}