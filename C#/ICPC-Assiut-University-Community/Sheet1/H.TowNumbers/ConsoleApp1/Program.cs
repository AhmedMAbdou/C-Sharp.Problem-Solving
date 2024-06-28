namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            double A = double.Parse(arr[0]);
            int A2 = (int)A;
            double B = double.Parse(arr[1]);
            int B2 = (int)B;

            int floor = (A2 / B2);
            int ceil = 0;
            if (A % B == 0)
            {
                ceil = (A2 / B2);
            }
            else
                ceil = (A2 / B2) + 1;

            double result = A / B;           //3.3
            int result2 = (int)result;       //3
            int round = 0;
            if (result - result2 < .5)
            {
                round = result2;
            }
            else if (result - result2 >= .5)
            {
                round = result2 + 1;
            }
            Console.WriteLine($"floor {A} / {B} = {floor}");
            Console.WriteLine($"ceil {A} / {B} = {ceil}");
            Console.WriteLine($"round {A} / {B} = {round}");

        }
    }
}
