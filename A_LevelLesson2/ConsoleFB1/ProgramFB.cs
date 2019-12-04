using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForLesson2;

namespace ConsoleFB1
{
    class ProgramFB
    {
        static int  nStart, tryStart;
        static uint fizz, buzz, nFinish, tryInput;
        static bool bl = true;

        static void Main(string[] args)
        {
            ConsoleStart();
            Console.WriteLine(MethodsForLesson.FizzBuzzMethod(nStart, nFinish, fizz, buzz));
            Console.ReadKey();
        }

        static void ConsoleStart()
        {
            do
            {
                Console.Write("Input nStart = ");
                if(Int32.TryParse(Console.ReadLine(), out  tryStart))
                {
                    nStart = tryStart;
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
                Console.Write("Input nFinish = ");
                if (UInt32.TryParse(Console.ReadLine(), out tryInput))
                {
                    nFinish = tryInput;
                    if (nStart > nFinish)
                    {
                        nStart = nStart + (int)nFinish;
                        nFinish = (uint)nStart - nFinish;
                        nStart = nStart - (int)nFinish;
                    }
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
                Console.Write("Input f = ");
                if (UInt32.TryParse(Console.ReadLine(), out tryInput))
                {
                    if (tryInput == 2) // простое же вроде.
                    {
                        fizz = tryInput;
                        bl = true;
                    }
                    else if (tryInput == 1)
                    {
                        bl = false;
                        Console.WriteLine("can not 1");
                    }
                    else
                    {
                        for (int i = 2; i <= tryInput - 1; i++)
                        {
                            if (tryInput % i == 0)
                            {
                                bl = false;
                                Console.WriteLine(" input prime number");
                                break;
                            }
                            else
                            {
                                fizz = tryInput;
                                bl = true;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error format");
                    bl = false;
                }
            } while (!bl);

            do
            {
                Console.Write("Input b = ");
                if (UInt32.TryParse(Console.ReadLine(), out tryInput))
                {
                    if (tryInput == 2)
                    {
                        buzz = tryInput;
                        bl = true;
                    }
                    else if (tryInput == 1)
                    {
                        bl = false;
                        Console.WriteLine("can not 1");
                    }
                    else
                    {
                        for (int i = 2; i <= tryInput - 1; i++)
                        {
                            if (tryInput % i == 0)
                            {
                                bl = false;
                                Console.WriteLine(" input prime number");
                                break;
                            }
                            else
                            {
                                buzz = tryInput;
                                bl = true;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error format");
                    bl = false;
                }
            } while (!bl);
        }
    }
}
