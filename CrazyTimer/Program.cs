namespace CrazyTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Countdown Timer Calculator Version 1.0");
            //var countdownTimer = new CountdownTimer();

            //countdownTimer.Hour = GetNumber("Enter the number of hours: ", 23);
            //countdownTimer.Minute = GetNumber("Enter the number of minutes: ", 59);
            //countdownTimer.Second = GetNumber("Enter the number of seconds: ", 59);

            //Console.WriteLine($"The total number of seconds is: {countdownTimer.CalcTotalSeconds()}");

            var elapseTimer = new ElapseTimer();
            Console.WriteLine("Enter the hour: ");
            elapseTimer.SetValue(Console.ReadLine()!, TimeType.Hour);
            Console.WriteLine("Enter the day: ");
            elapseTimer.SetValue(Console.ReadLine()!, TimeType.Day);
            Console.WriteLine("Enter the month: ");
            elapseTimer.SetValue(Console.ReadLine()!, TimeType.Month);
            Console.WriteLine("Enter the year: ");
            elapseTimer.SetValue(Console.ReadLine()!, TimeType.Year);

            if (elapseTimer.CalcElapseSeconds(out var result))
            {
                Console.WriteLine($"The total number of seconds is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid datetime");
            }
        }

        static int GetNumber(string msg, int max, int min = 0)
        {
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out var number) && min <= number && max >= number)
                {
                    return number;
                }

                Console.WriteLine("Invalid value");
            }
        }
    }
}
