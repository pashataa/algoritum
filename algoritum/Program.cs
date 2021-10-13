using System;

namespace algoritum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
        
            int x;

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Всяко x е решение");
                }
                else
                {
                    Console.WriteLine("Няма решение");
                }
            }
            else
            {
                x = -b / a;
                Console.WriteLine("x е ревно на:" + x );
            }
        }
    }
}
