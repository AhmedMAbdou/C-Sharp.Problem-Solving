namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            long val1 = long.Parse(arr[0]);
            long val2 = long.Parse(arr[1]);
            Console.WriteLine($"{val1} + {val2} = {val1 + val2}");
            Console.WriteLine($"{val1} * {val2} = {val1 * val2}");
            Console.WriteLine($"{val1} - {val2} = {val1 - val2}");

        }
    }
}
