namespace ConsoleApp1
{
    using System;

    public static class Calculator
    {
        public static void Run()
        {
            double num1 = 0;
            double num2 = 0;
            bool dontExit = true;
            bool firstTime = true;

            Console.WriteLine("Ange c som räknesätt för att nollställa eller x för att avsluta");
            while (dontExit)
            {
                if (firstTime)
                {
                    Console.Write("Skriv tal 1: ");
                    Double.TryParse(Console.ReadLine(), out num1);
                    firstTime = false;
                }
                else Console.Write($"Resultatet är: {num1}\n");
                Console.Write("Ange räknesätt: (+, -, *, /,^ (c = rensa, x = avsluta)");
                string thingToDo = Console.ReadLine();
                if (thingToDo != "x" && thingToDo != "c")
                {
                    Console.Write("Skriv tal 2: ");
                    Double.TryParse(Console.ReadLine(), out num2);
                }
                if (thingToDo == "+") num1 = Add(num1, num2);
                else if (thingToDo == "-") num1 = Subtract(num1, num2);
                else if (thingToDo == "/") num1 = Divide(num1, num2);
                else if (thingToDo == "*") num1 = Multiply(num1, num2);
                else if (thingToDo == "^") num1 = PowerOf(num1, num2);
                else if (thingToDo == "c")
                {
                    num1 = 0;
                    firstTime = true;
                }
                else if (thingToDo == "x") dontExit = false;

            }
        }

        private static double PowerOf(double num1, double num2)
        {
            return Math.Pow(num1, num2);
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
