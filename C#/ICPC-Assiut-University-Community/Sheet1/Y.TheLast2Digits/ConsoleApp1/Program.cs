using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                string[] arr = Console.ReadLine().Split(" ");

                BigInteger multiplicate = 1;
                for (long i = 0; i < arr.Length; i++)
                {
                    multiplicate = multiplicate * Convert.ToInt64(arr[i]);
                }
                string s = multiplicate.ToString();
                Console.WriteLine($"{s[s.Length - 2]}{s[s.Length - 1]}");



            }

        }
    }
}
