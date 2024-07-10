namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            long small = long.MaxValue;
            long big = long.MinValue;

            for (long i = 0; i < arr.Length; i++)
            {
                if (Convert.ToInt32(arr[i]) < small)
                {
                    long smallestnum = Convert.ToInt32(arr[i]);
                    small = smallestnum;
                }
                if (Convert.ToInt32(arr[i]) > big)
                {
                    long bigestnum = Convert.ToInt32(arr[i]);
                    big = bigestnum;
                }
            }
            Console.WriteLine($"{small} {big}");

        }
    }
}
