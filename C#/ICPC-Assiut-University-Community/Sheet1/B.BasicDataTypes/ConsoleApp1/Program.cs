namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            int val1 = int.Parse(arr[0]);
            long val2 = long.Parse(arr[1]);
            char var3 = char.Parse(arr[2]);
            float var4 = float.Parse(arr[3]);
            double var5 = double.Parse(arr[4]);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
