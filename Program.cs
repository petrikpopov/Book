using System;

namespace IndexBook10._02._2023HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Book a = new Book();
            a.Еnter();
            a.Print();
            a.EnterD();
            Console.WriteLine($"\t{a[0]}");
        }
    }
}
