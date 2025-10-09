using System;

namespace Example
{
    public class Calculator
    {
        // First method
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // Second method (does the same thing but has a different name)
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            int result1 = calc.AddNumbers(5, 3);
            int result2 = calc.Sum(5, 3);

            Console.WriteLine($"AddNumbers result: {result1}");
            Console.WriteLine($"Sum result: {result2}");
        }
    }
}
