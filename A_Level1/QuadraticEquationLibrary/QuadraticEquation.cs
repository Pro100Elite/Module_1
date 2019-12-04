using System;

namespace A_Level
{


    //public class QuadraticEquation
    //{
    //    public static double[] DiscriminantAndSqrt(double a, double b, double c)
    //    {
    //        double[] result = {1,2,3};
    //        result[0] = Math.Pow(b, 2) - 4 * a * c;
    //        result[1] = -(b - Math.Sqrt(result[0])) / (2*a);
    //        result[2] = -(b + Math.Sqrt(result[0])) / (2*a);
    //        return result;
    //    }

    public struct DiscriminantAndSqrt1
    {
        public double a, b, c, d, x1, x2;

        public string LineUr()
        {
            string line = $"{a}x^2+{b}x+{c} = {a}(x-{x1})(x-{x2})";
            return line;
        }

        public string LineUrForm()
        {
            string line = $"{a}x^\x00B2+{b}x+{c} = {a}(x-{x1})(x-{x2})";
            return line;
        }

        public void Decision()
        {
            d = Math.Pow(b, 2) - 4 * a * c;
            x1 = -(b - Math.Sqrt(d)) / (2 * a);
            x2 = -(b + Math.Sqrt(d)) / (2 * a);
        }
    }
}
