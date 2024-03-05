using System;

namespace Test_2
{
    public class Program
    {
        public double Sb1(double h, double r)
        {
            double result;
            result = Math.PI * 2 * h * r;
            return result;
        }
        public double Sb2(double h, double r)
        {
            double result;
            result = Math.PI * r * h * r;
            return result;
        }
        static void Main(string[] args)
        {
        }
    }
}
