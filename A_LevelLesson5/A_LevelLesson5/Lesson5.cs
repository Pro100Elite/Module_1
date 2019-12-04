using MyLibraryArrays;
using System;
using System.Linq;

namespace A_LevelLesson5
{
    class Lesson5
    {
        static int n, num;
        static int[][,] ar;

        static bool isMenu = true;

        static void Main(string[] args)
        {
            n = ReadNumberFromConsole("Input N = ");
            CreatorArray();
            ConsoleMenu();
        }

        static int ReadNumberFromConsole(string str)
        {
            int number;
            Console.Write(str);
            while (!int.TryParse(Console.ReadLine(), out number) | number <= 0)
            {
                Console.WriteLine("Incorrect number, try again");
            }
            return number;
        }

        static void ShowResult(int[,] ar)
        {
            int length = ar.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write($"{ar[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("==============");
        }

        static void ShowTopResult(int[,] ar)
        {
            int length = ar.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (j >= i)
                    {
                        Console.Write($"{ar[i, j]} \t");
                    }
                    else
                    {
                        Console.Write($"{0} \t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("==============");
        }

        static void ShowBotResult(int[,] ar)
        {
            int length = ar.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (j <= i)
                    {
                        Console.Write($"{ar[i, j]} \t");
                    }
                    else
                    {

                        Console.Write($"{0} \t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("==============");
        }

        static void ShowResultTrans(int[][,] ar)
        {
            Console.WriteLine("Transported");
            ar[num - 1] = ArrayMethods.TransposeMatrix(ar[num - 1]);
            ShowResult(ar[num - 1]);
            ShowTopResult(ar[num - 1]);
            ShowBotResult(ar[num - 1]);
            Console.WriteLine("==============");
        }

        static void CreatorArray()
        {
            ar = ArrayMethods.ArrayCreation(n);
        }

        static void ConsoleMenu()
        {
            while (isMenu)
            {
                Console.WriteLine(" 1 - Show Array");
                Console.WriteLine(" 2 - Create new Array");
                Console.WriteLine(" 3 - Exit");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(" = Selected\n");
                        //Console.Clear();
                        num = ReadNumberFromConsole("Input Num = ");
                        if (num <= ar.Count())
                        {
                            ShowResult(ar[num - 1]);
                            ShowResultTrans(ar);
                        }
                        else
                        {
                            Console.WriteLine(" Not Found");
                        }
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine(" = Selected\n");
                        //Console.Clear();
                        n = ReadNumberFromConsole("Input Num = ");
                        CreatorArray();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine(" = Selected\n");
                        isMenu = false;
                        break;
                }
            }
        }
    }
}
