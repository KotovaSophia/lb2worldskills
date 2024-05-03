internal class Program
{
    enum Time_For_Day : int
    {
        Morning,
        Afternoon,
        Evening,
        Night
    }
    enum Week_Day : int
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    private static void Main(string[] args)
    {
        Console.Write("Введите день недели в формате: [1-7] ");
        int day_of_week = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите время в формате: [0-23]: ");
        int time = Convert.ToInt32(Console.ReadLine());

        Week_Day day = (Week_Day)day_of_week;
        Time_For_Day nowtime = (Time_For_Day)GetTime(time);

        Console.WriteLine($"Now: {day}\nTime: {nowtime}.");

        int GetTime(int time)
        {
            if (time >= 7 & time <= 12)
            {
                time = 0;
                return time;
            }
            if (time >= 13 & time <= 18)
            {
                time = 1;
                return time;
            }
            if (time >= 18 & time <= 23)
            {
                time = 2;
                return time;
            }
            else
            {
                time = 3;
                return time;
            }
        }
    }
}