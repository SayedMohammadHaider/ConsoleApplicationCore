using System;

namespace ConsoleApplicationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CalculationMethod();
        }

        public void CalculationMethod()
        {
            Console.WriteLine("Enter First Number");

            var firstNumber = Console.ReadLine();
            Console.WriteLine("Enter Second Number");
            var secondNumber = Console.ReadLine();
            Program program = new Program();
            var sum = program.Addition(Convert.ToInt32(firstNumber), Convert.ToInt32(secondNumber));
            Console.WriteLine("The sum of {0} and {1} is {2}", firstNumber, secondNumber, sum);
            Console.WriteLine("Press Y key to calculate other number");
            var pressedKey = Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
            if (pressedKey.Key.ToString() == "y" || pressedKey.Key.ToString() == "Y")
            {
                CalculationMethod();
            }
        }

        public int Addition(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
