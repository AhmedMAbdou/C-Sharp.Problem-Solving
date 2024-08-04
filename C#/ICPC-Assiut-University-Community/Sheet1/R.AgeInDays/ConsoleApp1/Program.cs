namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int year = 365;
            const int month = 30;

            int input = int.Parse(Console.ReadLine());  //800

            int yearsresult = input / 365;              //          800/365 = 2
            int monthresult = (input - (yearsresult * year)) / 30; // (800-(2*365))/30 =2
            int dayresult = (input - (yearsresult * year)) - (monthresult * month);                //

            Console.WriteLine($"{yearsresult} years");
            Console.WriteLine($"{monthresult} months");
            Console.WriteLine($"{dayresult} days");

        }
    }
}
