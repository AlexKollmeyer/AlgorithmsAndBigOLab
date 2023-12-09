namespace Algortithms_BigOLab
{
    internal class Program
        
    // O(1) Constant
    {static bool EvenOrOdd (int value)
            {
            if (value % 2 == 0)
            {
                return true;
            }
            else return false;
            }
        // O(n) Linear
        static bool LessThan100 (List<int> ListOfNumbers)
        {
            foreach (var item in ListOfNumbers)
            {
                if(item >= 100)
                {
                    return false;
                }
                
            }
            return true;
        }
        // O(n^2)
        static bool RepeatedNames(List<string> ListOfNames)
        {
            List<string> TempList = new List<string> { };
            foreach (var item in ListOfNames)
            {
                foreach (var item1 in TempList)
                {
                    if (item == item1)
                    {
                        return true;
                    }
                }
                TempList.Add(item);
            }
            return false;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(EvenOrOdd(1));
            Console.WriteLine(EvenOrOdd(2));
            Console.WriteLine(EvenOrOdd(35));
            Console.WriteLine(EvenOrOdd(16));
            List<int> NumberList1 = new List<int> { 1, 2, 12, 56 };
            List<int> NumberList2 = new List<int> { 5, 99, 56, 33, 100, };
            Console.WriteLine(LessThan100(NumberList1));
            Console.WriteLine(LessThan100(NumberList2));
            List<string> NameList1 = new List<string> { "Ashley", "Arron", "Alex", "Dave" };
            List<string> NameList2 = new List<string> { "Ashley", "Arron", "Alex", "Dave", "Ashley" };
            Console.WriteLine(RepeatedNames(NameList1));
            Console.WriteLine(RepeatedNames(NameList2));
        }
    }
}