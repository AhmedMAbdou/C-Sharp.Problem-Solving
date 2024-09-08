using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BigInteger x = BigInteger.Pow(8376260,70);
            //Console.WriteLine(x);
            while (true)
            {
                string[] arr = Console.ReadLine().Split(" ");
                BigInteger[] arr_int = Array.ConvertAll(arr, BigInteger.Parse);

                BigInteger x = BigInteger.Pow(arr_int[0], (int)arr_int[1]);
                BigInteger y = BigInteger.Pow(arr_int[2], (int)arr_int[3]);
                if (x > y)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

        }
    }
}
