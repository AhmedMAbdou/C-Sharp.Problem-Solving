namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long input2 = (int)input[0];
            if (input2 >= 48 && input2 <= 57)
            {
                Console.WriteLine("IS DIGIT");
            }
            else if (input2 >= 65 && input2 <= 90)
            {
                Console.WriteLine("ALPHA\nIS CAPITAL");
            }
            else if (input2 >= 97 && input2 <= 122)
            {
                Console.WriteLine("ALPHA\r\nIS SMALL");
            }

        }
    }
}
