namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(".");

            if (Convert.ToInt32(arr[1]) == 000)
            {
                Console.WriteLine($"int {arr[0]}");
            }
            else if (Convert.ToInt32(arr[1]) != 000)
            {
                Console.WriteLine($"float {arr[0]} 0.{arr[1]}");
            }

        }
    }
}
