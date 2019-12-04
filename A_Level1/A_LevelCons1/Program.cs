using System;
using A_Level;

namespace A_LevelCons1
{
    class Program
    {
        static double tryNum;
        static bool bl = true;
        static DiscriminantAndSqrt1 Dis;

        static void Main(string[] args)
        {
            ConsolStart();
            Dis.Decision();
            ConsolWr();
            Console.ReadKey();
        }

        static void ConsolStart()
        {
            do
            {
                Console.Write("A = ");
                if (double.TryParse(Console.ReadLine(), out tryNum))
                {
                    Dis.a = tryNum;
                }
                else
                {
                    tryNum = 0;
                    Console.Write("Введите вещественное число ");
                }
            }
            while (tryNum == 0);

            do
            {
                Console.Write("B = ");
                if (double.TryParse(Console.ReadLine(), out tryNum))
                {
                    bl = true;
                    Dis.b = tryNum;
                }
                else
                {
                    bl = false;
                    Console.Write("Введите вещественное число ");
                }
            }
            while (!bl);

            do
            {
                Console.Write("C = ");
                if (double.TryParse(Console.ReadLine(), out tryNum))
                {
                    bl = true;
                    Dis.c = tryNum;
                }
                else
                {
                    bl = false;
                    Console.Write("Введите вещественное число ");
                }
            }
            while (!bl);
        }

        static void ConsolWr()
        {
            if (Dis.d < 0)
            {
                Console.WriteLine("Нет корней");
            }
            else if (Dis.d == 0)
            {
                Console.WriteLine("Один корень X1 = {0}", Dis.x1);
            }
            else
            {
                Console.WriteLine("Два корня X1 = {0}, X2 = {1}", Dis.x1, Dis.x2);
                Console.WriteLine(Dis.LineUr().Replace("--", "+"));
            }
        }
    }
}
