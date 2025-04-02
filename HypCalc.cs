using System;

namespace Other_CS_Cal
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your first number");
            double num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose your second number");
            double num2 = int.Parse(Console.ReadLine());
            num1 = Math.Pow(num1, 2);
            num2 = Math.Pow(num2, 2);
            double cSqr = num1 + num2;
            double hyp = Math.Sqrt(cSqr);

            Console.WriteLine(hyp);

        }
    }
}