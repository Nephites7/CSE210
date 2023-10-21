using System;
using System.Collections.Generic;

namespace NumberListAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Please enter a list of numbers. Enter 0 to finish.");

            while (true)
            {
                Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    if (inputNumber == 0)
                        break;

                    numbers.Add(inputNumber);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("No numbers were entered.");
            }
            else
            {
                int sum = 0;
                int max = numbers[0];

                foreach (int number in numbers)
                {
                    sum += number;

                    if (number > max)
                    {
                        max = number;
                    }
                }

                double average = (double)sum / numbers.Count;

                Console.WriteLine($"The sum of the numbers is: {sum}");
                Console.WriteLine($"The average of the numbers is: {average}");
                Console.WriteLine($"The largest number in the list is: {max}");
            }
        }
    }
}
