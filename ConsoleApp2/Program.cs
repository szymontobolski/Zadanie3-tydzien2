using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Długośc przekątnej na podstawie długości i szerokości prostokąta. Autor - Szymon Tobolski");
            Console.WriteLine("Podaj długość prostokąta");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj szerokość prostokąta");
            int b = int.Parse(Console.ReadLine());

            int a1 = (a * a);
            int b1 = (b * b);

            int c = (a1 + b1);
           var c1 = Math.Sqrt(c);
            Console.WriteLine("Długość przekątnej to: " + c1);
        }


      
    }
}
