using MobLibrary1;
using System;
using System.Linq;

namespace mod1
{
    class Program
    {
        static bool isMenu = true;

        static void Main(string[] args)
        {
            TxtMethods.ReadTxTtoList();
            ConsoleStart();
        }

        static void ConsoleStart()
        {
            Console.Clear();
            while (isMenu)
            {
                Console.WriteLine("Select num to\n 1 - Add\n 2 - Show\n 3 - Delete\n 4 - Exit");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Input Name = ");
                        string name = Console.ReadLine();
                        int age = ConsoleReadInt("Input Age = ");
                        double hours = ConsoleReadFloat("Input Hours = ");
                        string position;
                        string team;
                        Console.WriteLine("\nSelect position\n 1 - Back Dev\n 2 - Front Dev\n 3 - Jun");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                Console.Clear();
                                position = "Back Dev";
                                break;

                            case ConsoleKey.D2:
                                Console.Clear();
                                position = "Front Dev";
                                break;
                            default:
                                Console.Clear();
                                position = "Jun";
                                break;
                        }

                        Console.WriteLine("\nSelect team\n 1 - HG\n 2 - Plarium\n 3 - NoName");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                Console.Clear();
                                team = "HG";
                                break;
                            case ConsoleKey.D2:
                                Console.Clear();
                                team = "Plarium";
                                break;
                            default:
                                Console.Clear();
                                team = "NoName";
                                break;
                        }
                        var person = new PersonTemplate(name, age, position, team, hours);
                        ListCreator.Add(person);
                        TxtMethods.WriteTxT(person.ToString());
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        double outHsHg = 0f;
                        double outHsPl = 0f;
                        double outHsDf = 0f;

                        foreach (var list in ListCreator.Acc)
                        {
                            if (list.team.Contains("HG"))
                            {
                                outHsHg += list.workHours;
                            }
                            else if (list.team.Contains("Plarium"))
                            {
                                outHsPl += list.workHours;
                            }
                            else
                            {
                                outHsDf += list.workHours;
                            }
                            Console.WriteLine($" Name = {list.name}, Age = {list.age}, Position = {list.position}, Team = {list.team}, WorkHours = {list.workHours}, Guid = {list.guidStr}\n");
                        }
                        Console.WriteLine($"HG works = {outHsHg} h, Plarium works = {outHsPl} h, Other works = {outHsDf} h ");
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Input number Order");
                        int index = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (index + 1 <= ListCreator.Acc.Count())
                        {
                            ListCreator.Acc.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Not found");
                        }
                        TxtMethods.ReCreateTxT();
                        foreach (var lines in ListCreator.Acc)
                        {
                            TxtMethods.WriteTxT(lines.ToString());
                        }
                        break;

                    case ConsoleKey.D4:
                        isMenu = false;
                        break;
                }
            }
        }


        static double ConsoleReadFloat(string str)
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

        static int ConsoleReadInt(string str)
        {
            int tryNum;
            Console.WriteLine(str);
            while (!int.TryParse(Console.ReadLine(), out tryNum) | tryNum <= 0)
            {
                Console.WriteLine("Error format");
            }
            Console.Clear();
            return tryNum;
        }
    }
}
