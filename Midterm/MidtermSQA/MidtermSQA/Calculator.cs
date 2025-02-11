using System;

namespace MidtermSQA
{
    public class SimpleCalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Division by zero is not allowed");
            return a / b;
        }
    }

    class Calculator
    {
        static void Main(string[] args)
        {
            SimpleCalculator calculator = new SimpleCalculator();

            Console.WriteLine("Addition: 5 + 3 = " + calculator.Add(5, 3));
            Console.WriteLine("Subtraction: 5 - 3 = " + calculator.Subtract(5, 3));
            Console.WriteLine("Multiplication: 5 * 3 = " + calculator.Multiply(5, 3));
            Console.WriteLine("Division: 5 / 3 = " + calculator.Divide(5, 3));
        }
    }
}