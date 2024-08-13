namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");        

            long[] arr2 = new long[arr.Length];

            for (long i = 0; i < arr.Length; i++)
            {
                long ConvertToInt = Convert.ToInt32(arr[i]);
                arr2[i] = ConvertToInt;
            }
            Array.Sort(arr2);
            for (long i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine();
            for (long i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
