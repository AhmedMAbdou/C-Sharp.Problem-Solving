using System;
using System.Numerics;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            BigInteger result = 0;
            for (BigInteger i = 1; i <= input; i++)
            {
                result = result + i;
            }
            Console.WriteLine(result);

        }
    }
}
