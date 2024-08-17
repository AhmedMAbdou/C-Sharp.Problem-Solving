namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            if (arr[1] == ">")
            {
                if (Convert.ToInt32(arr[0]) > Convert.ToInt32(arr[2]))
                {
                    Console.WriteLine("Right");
                }
                else Console.WriteLine("Wrong");
            }
            else if (arr[1] == "<")
            {
                if (Convert.ToInt32(arr[0]) < Convert.ToInt32(arr[2]))
                {
                    Console.WriteLine("Right");
                }
                else Console.WriteLine("Wrong");
            }
            else if (arr[1] == "=")
            {
                if (Convert.ToInt32(arr[0]) == Convert.ToInt32(arr[2]))
                {
                    Console.WriteLine("Right");
                }
                else Console.WriteLine("Wrong");
            }

        }
    }
}
