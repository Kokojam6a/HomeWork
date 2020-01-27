using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Plus plas = new Plus () ;
            Console.WriteLine (plas.pluses (x,y));
            Division Div = new Division();
            Console.WriteLine(Div.pluses(x, y));
            multiplication mult = new multiplication();
            Console.WriteLine(mult.pluses(x, y));
            
            
        }
    }
}
