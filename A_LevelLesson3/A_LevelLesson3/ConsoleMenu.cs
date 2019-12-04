using KettlebellLib;
using System;
using System.Linq;

namespace A_LevelLesson3
{
    class ConsoleMenu
    {
        static bool rubberCover;
        static bool isMenu = true;

        static double kg, height, caseDiameter, handleDiameter;

        static string strName;


        static void Main(string[] args)
        {
            ConsoleStart();
        }

        static void ConsoleStart()
        {
            Console.Clear();
            kg = ConsoleReadNum("Input kg = ");
            height = ConsoleReadNum("Input height = ");
            caseDiameter = ConsoleReadNum("Input caseDiameter = ");
            handleDiameter = ConsoleReadNum("Input handleDiameter = ");

            Console.WriteLine("\nSelect ManufacturerName\n 1 - Powerfull\n 2 - WolfKett");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    strName = "Powerfull";
                    Console.WriteLine(" = Selected\n");
                    break;

                case ConsoleKey.D2:
                    Console.WriteLine(" = Selected\n");
                    strName = "WolfKett";
                    break;
                default:
                    Console.WriteLine(" = Selected\n");
                    strName = "China";
                    break;
            }

            Console.WriteLine("\nSelect RubberCover\n 1 - Yes\n 2 - falls");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    rubberCover = true;
                    Console.WriteLine(" = Selected\n");
                    break;

                case ConsoleKey.D2:
                    Console.WriteLine(" = Selected\n");
                    rubberCover = false;
                    break;
                default:
                    Console.WriteLine(" = Selected\n");
                    rubberCover = false;
                    break;
            }
            var ketel = new Kettlebell(strName, kg, rubberCover, height, caseDiameter, handleDiameter);
            KettlebellKeeper.kettlebells.Add(ketel);
            Console.Clear();
            ConsoleMenuCreatingAndDelete();
        }

        static double ConsoleReadNum(string str)
        {
            double tryNum;
            Console.WriteLine(str);
            while (!double.TryParse(Console.ReadLine(), out tryNum) | tryNum <= 0)
            {
                Console.WriteLine("Error format");
            }
            Console.Clear();
            return tryNum;
        }

        static void ConsoleMenuCreatingAndDelete()
        {

            while (isMenu)
            {
                Console.WriteLine("press 1 (To order)");
                Console.WriteLine("press 2 (Show my orders)");
                Console.WriteLine("press 3 (Delete order)");
                Console.WriteLine("press 4 (Exit)");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(" = Selected\n");
                        ConsoleStart();
                        break;

                    case ConsoleKey.D2:
                        foreach (var kt in KettlebellKeeper.kettlebells)
                        {
                            Console.WriteLine(kt);
                        }
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Input number Order");
                        int index = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (index + 1 <= KettlebellKeeper.kettlebells.Count())
                        {
                            KettlebellKeeper.kettlebells.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Not found");
                        }
                        break;
                    case ConsoleKey.D4:
                        isMenu = false;
                        break;
                }
            }
            Console.Clear();
        }
    }
}
