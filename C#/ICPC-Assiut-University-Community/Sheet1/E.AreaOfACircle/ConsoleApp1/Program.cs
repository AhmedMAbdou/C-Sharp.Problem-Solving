namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double p = 3.141592653;
            double input = double.Parse(Console.ReadLine());
            double result = p * Math.Pow(input, 2);
            Console.WriteLine(result);

        }
    }
}
