namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");

            double item1 = Convert.ToDouble(arr[0]);
            double item2 = Convert.ToDouble(arr[1]);

            if (item1 > 0 && item2 > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (item1 > 0 && item2 < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (item1 < 0 && item2 > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (item1 < 0 && item2 < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (item1 == 0 && item2 == 0)
            {
                Console.WriteLine("Origem");
            }
            else if ((item1 > 0 | item1 < 0) && item2 == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if ((item2 > 0 | item2 < 0) && item1 == 0)
            {
                Console.WriteLine("Eixo Y");
            }

        }
    }
}
