namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            long val1 = long.Parse(arr[0]);
            long val2 = long.Parse(arr[1]);
            long val3 = long.Parse(arr[2]);
            long val4 = long.Parse(arr[3]);

            long result = ((val1 * val2) - (val3 * val4));
            Console.WriteLine("Difference = " + result);

        }
    }
}
