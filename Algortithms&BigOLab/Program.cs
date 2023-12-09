namespace Algortithms_BigOLab
{
    internal class Program

    {static bool EvenOrOdd (int value)
            {
            if (value % 2 == 0)
            {
                return (true);
            }
            else return (false);
            }
        static void Main(string[] args)
        {

            Console.WriteLine(EvenOrOdd(1));
            Console.WriteLine(EvenOrOdd(2));
            Console.WriteLine(EvenOrOdd(35));
            Console.WriteLine(EvenOrOdd(16));
        }
    }
}