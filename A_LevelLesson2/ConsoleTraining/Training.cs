using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForLesson2;

namespace ConsoleTraining
{
    class Training
    {
        static double x, y, z, tryNum;
        
        static string name;

        static bool bl = true;
        static bool isMenu = true;

        static List<SportsMan> listSport = new List<SportsMan> { };

        static void Main(string[] args)
        {
            ConsoleStart();
        }

        static void ConsoleStart()
        {
            do
            {
                Console.Write("Input X = ");
                if (double.TryParse(Console.ReadLine(), out tryNum) & tryNum > 0)
                {
                    x = tryNum;
                    bl = true;
                }
                else
                {
                    Console.WriteLine("Error format");
                    bl = false;
                }
            } while (!bl);

            do
            {
                Console.Write("Input Y = ");
                if (double.TryParse(Console.ReadLine(), out tryNum))
                {
                    y = tryNum;
                    bl = true;
                }
                else
                {
                    Console.WriteLine("Error format");
                    bl = false;
                }
            } while (!bl);

            do
            {
                Console.Write("Input Z = ");
                if (double.TryParse(Console.ReadLine(), out tryNum) & tryNum >= x)
                {
                    z = tryNum;
                    bl = true;
                }
                else
                {
                    Console.WriteLine("Error format");
                    bl = false;
                }
            } while (!bl);
            Console.Write("Input Name = ");
            name = Console.ReadLine();
            listSport.Add(MethodsForLesson.CompletedTraining(x,y,z,name));
            ConsoleMenu();
        }

        static void ConsoleMenu()
        {
            while(isMenu)
            {
                Console.WriteLine("press 1 (next skier)");
                Console.WriteLine("press 2 (show skier)");
                Console.WriteLine("press 3 (Exite)");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(" = Selected\n");
                        ConsoleStart();
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine(" = Selected\n");
                        Console.WriteLine("Input number skier");
                        int indexSkier = Convert.ToInt32(Console.ReadLine()) - 1;

                        if(indexSkier +1 <= listSport.Count())
                        {
                            Console.WriteLine($@"numer {indexSkier + 1}, 
name {listSport[indexSkier].name}, 
Days = {listSport[indexSkier].day}, 
X = {listSport[indexSkier].x}, Y = {listSport[indexSkier].y} %, Z = {listSport[indexSkier].z}");
                        }
                        else
                        {
                            Console.WriteLine("Not found");
                        }
                        break;

                    case ConsoleKey.D3:
                        isMenu = false;
                        break;
                }
            }
        }
    }
}
