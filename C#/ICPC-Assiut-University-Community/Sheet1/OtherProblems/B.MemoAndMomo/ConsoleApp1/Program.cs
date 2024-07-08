namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            long a = long.Parse(arr[0]);
            long b = long.Parse(arr[1]);
            long k = long.Parse(arr[2]);

            if (a % k == 0 & b % k == 0)
                Console.WriteLine("Both");
            else if (a % k == 0 & b % k != 0)
                Console.WriteLine("Memo");
            else if (b % k == 0 & a % k != 0)
                Console.WriteLine("Momo");
            else if (a % k != 0 & b % k != 0)
                Console.WriteLine("No One");
        }
    }
}
