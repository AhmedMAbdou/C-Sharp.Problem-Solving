namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            if (char.IsUpper(input))
            {
                long upper = (int)input;
                long upper2 = upper + 32;
                Console.WriteLine(((char)upper2));
            }
            else if (char.IsLower(input))
            {
                long lower = (int)input;
                long lower2 = lower - 32;
                Console.WriteLine(((char)lower2));
            }

        }
    }
}
