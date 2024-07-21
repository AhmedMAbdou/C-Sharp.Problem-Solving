namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();                //536+20
            string[] arr = new string[50];

            if (input.Contains("+"))
            {
                int indexsign = input.IndexOf("+");   //3

                for (int i = 0; i < indexsign; i++)
                {
                    string firstnum = (input[i]).ToString();   //536
                    arr[0] = arr[0] + firstnum;                            //536

                }
                //Console.WriteLine(Convert.ToInt64(arr[0]) +20);
                for (int i = indexsign + 1; i < input.Length; i++)
                {
                    string secondnum = (input[i]).ToString();
                    arr[1] = arr[1] + secondnum;
                }
                Console.WriteLine(Convert.ToInt32(arr[0]) + Convert.ToInt32(arr[1]));
            }

            if (input.Contains("-"))
            {
                int indexsign = input.IndexOf("-");   //3

                for (int i = 0; i < indexsign; i++)
                {
                    string firstnum = (input[i]).ToString();   //536
                    arr[0] = arr[0] + firstnum;                            //536

                }
                for (int i = indexsign + 1; i < input.Length; i++)
                {
                    string secondnum = (input[i]).ToString();
                    arr[1] = arr[1] + secondnum;
                }
                int result = Convert.ToInt32(arr[0]) - Convert.ToInt32(arr[1]);
                Console.WriteLine(result);
            }
            if (input.Contains("*"))
            {
                int indexsign = input.IndexOf("*");   //3

                for (int i = 0; i < indexsign; i++)
                {
                    string firstnum = (input[i]).ToString();   //536
                    arr[0] = arr[0] + firstnum;                            //536

                }
                //Console.WriteLine(Convert.ToInt64(arr[0]) +20);
                for (int i = indexsign + 1; i < input.Length; i++)
                {
                    string secondnum = (input[i]).ToString();
                    arr[1] = arr[1] + secondnum;
                }
                int result2 = Convert.ToInt32(arr[0]) * Convert.ToInt32(arr[1]);
                Console.WriteLine(result2);
            }
            if (input.Contains("/"))
            {
                int indexsign = input.IndexOf("/");   //3

                for (int i = 0; i < indexsign; i++)
                {
                    string firstnum = (input[i]).ToString();   //536
                    arr[0] = arr[0] + firstnum;                            //536

                }
                //Console.WriteLine(Convert.ToInt64(arr[0]) +20);
                for (int i = indexsign + 1; i < input.Length; i++)
                {
                    string secondnum = (input[i]).ToString();
                    arr[1] = arr[1] + secondnum;
                }
                Console.WriteLine(Convert.ToInt32(arr[0]) / Convert.ToInt32(arr[1]));
            }

        }
    }
}
