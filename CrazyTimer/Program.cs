namespace CrazyTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Countdown Timer Calculator Version 1.0");
            var countdownTimer = new CountdownTimer();

            Console.Write("Enter the number of hours: ");
            countdownTimer.Hour = int.Parse(Console.ReadLine()!);

            Console.Write("Enter the number of minutes: ");
            countdownTimer.Minute = int.Parse(Console.ReadLine()!);

            Console.Write("Enter the number of seconds: ");
            countdownTimer.Second = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"The total number of seconds is: {countdownTimer.CalcTotalSeconds()}");
        }
    }
}
