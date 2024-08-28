namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] arr = Console.ReadLine().Split(" ");
                long L1 = long.Parse(arr[0]);
                long R1 = long.Parse(arr[1]);
                long L2 = long.Parse(arr[2]);
                long R2 = long.Parse(arr[3]);

                if ((L2 < L1 & R2 < L1) | (L2 > R1 & R2 > R1))
                {
                    Console.WriteLine("-1");
                }
                else if ((L2 <= L1 & R2 <= R1) | (L2 < L1 & R2 > R1))
                {
                    Console.WriteLine($"{Math.Max(L1, L2)} {Math.Min(R1, R2)}");
                }
                else if (L2 >= L1 & R2 <= R1)
                {
                    Console.WriteLine($"{Math.Max(L1, L2)} {Math.Min(R1, R2)}");
                }
                else if(L2 >= L1 & R2>=R1)
                {
                    Console.WriteLine($"{Math.Max(L1, L2)} {Math.Min(R1, R2)}");
                }

            }
            
        }
    }
}
