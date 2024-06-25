namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            string val1 = arr[0][(arr[0].Length) - 1].ToString();
            string val2 = arr[1][(arr[1].Length) - 1].ToString();

            Console.WriteLine(Convert.ToInt32(val1) + Convert.ToInt32(val2));

        }
    }
}
