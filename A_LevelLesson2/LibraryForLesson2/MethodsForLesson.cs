using System;

namespace LibraryForLesson2
{
    public struct SportsMan
    {
        public double x;
        public double y;
        public double z;

        public int day;

        public string name;
    }


public class MethodsForLesson
    {
        public static string FizzBuzzMethod(int nStart, uint nFinish, uint fizz, uint buzz)
        {
            string str = "";
            for (int i = nStart; i < nFinish; i++)
            {
                if (i % fizz == 0 & i % buzz == 0)
                {
                    str += "FizzBuzz";
                }
                else if (i % fizz == 0)
                {
                    str += "Fizz";
                }
                else if (i % buzz == 0)
                {
                    str += "Buzz";
                }
                else
                {
                    str += $"{i}";
                }
                str += "\n";
            }
            return str;
        }

        public static  SportsMan CompletedTraining( double x, double y, double z, string name)
        {
            SportsMan SpObj = new SportsMan();
            int days = 1;
            SpObj.x = x;
            SpObj.y = y;
            SpObj.z = z;

            y = 1 + (y / 100);

            for (double i = x; i < z; i += x)
            {
                x *= y;
                days += 2;
            }

            SpObj.day = days;
            SpObj.name = name;
            return SpObj;
        }
    }
}
