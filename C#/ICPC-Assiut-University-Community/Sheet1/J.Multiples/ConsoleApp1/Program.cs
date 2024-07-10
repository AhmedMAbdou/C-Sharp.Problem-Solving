namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");

            long A = long.Parse(arr[0]);
            long B = long.Parse(arr[1]);
            if (A % B == 0 || B % A == 0)
                Console.WriteLine("Multiples");
            else Console.WriteLine("No Multiples");

        }
    }
}
