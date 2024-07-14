namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            string[] arr2 = Console.ReadLine().Split(" ");
            for (long i = 1; i < arr.Length; i = i + 2)
            {
                if (arr[i] == arr2[i])
                {
                    Console.WriteLine("ARE Brothers");
                }
                else
                    Console.WriteLine("NOT");
            }

        }
    }
}
