namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Calculator
    {
        public static void Run()
        {
            double num1 = 0;
            double num2;

            if (num1 != 0)
            {
                Console.WriteLine("Skriv tal 1:");
                Double.TryParse(Console.ReadLine(), out num1);
            }
            Console.WriteLine("Skriv tal 2:");
            Double.TryParse(Console.ReadLine(), out num2);
        }
        private static double Add(double a, double b)
        {
            return a + b;
        }
        private static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
