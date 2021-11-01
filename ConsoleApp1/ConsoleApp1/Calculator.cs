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
            bool dontExit = true;

            while(dontExit)
            if (num1 != 0)
            {
                Console.Write("Skriv tal 1: ");
                Double.TryParse(Console.ReadLine(), out num1);
            }
            else Console.Write($"Tal 1 är: {num1}");
            Console.Write("Skriv tal 2:");
            string thingToDo = Console.ReadLine();
            Double.TryParse(Console.ReadLine(), out num2);

            if (thingToDo == "+") Add(num1, num2);
            else if (thingToDo == "-") Subtract(num1, num2);
            else if (thingToDo == "/") Divide(num1, num2);
            else if (thingToDo == "*") Multiply(num1, num2);
            else if (thingToDo == "c") num1 = 0;
            else if (thingToDo == "x") dontExit = true;
        }
        private static double Add(double a, double b)
        {
            return a + b;
        }


        private static double Subtract(double a, double b)
        {
            return a - b;
        }

        private static double Divide(double a, double b)
        {
            return a / b;

        }

        private static double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
