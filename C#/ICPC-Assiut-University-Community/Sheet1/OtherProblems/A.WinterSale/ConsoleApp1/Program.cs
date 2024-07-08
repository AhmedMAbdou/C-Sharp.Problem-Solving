namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            float num1 = long.Parse(arr[0]);
            float num2 = long.Parse(arr[1]);
            float result = num2 / ((100-num1)/100);
            Console.WriteLine(result);
        }
    }
}
