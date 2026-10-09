using System;
using System.Collections.Generic;

public class HelloWorld {
    public static void Main(string[] args) {
                    List<int> numbers = new();

            // P - Print numbers
            if (numbers.Count == 0)
            {
                Console.WriteLine("[] - the list is empty");
            }
            else
            {
                Console.Write("[ ");
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine("]");
            }

            // A - Add a number
            Console.Write("Enter an integer to add: ");
            int num = Convert.ToInt32(Console.ReadLine());

            numbers.Add(num);
            Console.WriteLine(num + " added");

            // M - Display mean of the numbers
            if (numbers.Count == 0)
            {
                Console.WriteLine("Unable to calculate the mean - no data");
            }
            else
            {
                double sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum = sum + numbers[i];
                }

                double mean = sum / numbers.Count;
                Console.WriteLine("The mean is " + mean);
            }

            // S - Display the smallest number
            if (numbers.Count == 0)
            {
                Console.WriteLine("Unable to determine the smallest number - list is empty");
            }
            else
            {
                int min = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
                Console.WriteLine("The smallest number is " + min);
            }

            // L - Display the largest number
            if (numbers.Count == 0)
            {
                Console.WriteLine("Unable to determine the largest number - list is empty");
            }
            else
            {
                int max = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                }
                Console.WriteLine("The largest number is " + max);
            }
      // F - Find a number in the list
            if (numbers.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.Write("Enter number to find: ");
                int target = Convert.ToInt32(Console.ReadLine());

                bool found = false;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == target)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    Console.WriteLine(target + " is in the list");
                }
                else
                {
                    Console.WriteLine(target + " is not in the list");
                }
            }

            // C - Clear out the list
            numbers.Clear();
            Console.WriteLine("List cleared");

            // Q - Quit
            Console.WriteLine("Goodbye");
        
        
    }
}
