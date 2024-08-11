namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            if (input >= 0 && input <= 25)
            {
                Console.WriteLine("Interval [0,25]");
            }
            else if (input > 25 && input <= 50)
            {
                Console.WriteLine("Interval (25,50]");
            }
            else if (input > 50 && input <= 75)
            {
                Console.WriteLine("Interval (50,75]");
            }
            else if (input > 75 && input <= 100)
            {
                Console.WriteLine("Interval (75,100]");
            }
            else
            {
                Console.WriteLine("Out of Intervals");
            }

        }
    }
}
