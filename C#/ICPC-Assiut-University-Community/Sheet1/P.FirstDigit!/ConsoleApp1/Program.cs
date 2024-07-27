namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());
            if (input[0] % 2 == 0)
            {
                Console.WriteLine("EVEN");
            }
            else
            {
                Console.WriteLine("ODD");
            }
        }
    }
}
