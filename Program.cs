 using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool running = true;

        while (running)
        {
            // Display menu options
            Console.WriteLine("\nP - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("F - Find a number");
            Console.WriteLine("C - Clear list");
            Console.WriteLine("Q - Quit");
            Console.Write("\nEnter your choice: ");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) continue;

            // Convert choice to uppercase
            char choice = char.ToUpper(input[0]);

            switch (choice)
            {
                case 'P':
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    else
                    {
                        Console.Write("[ ");
                        foreach (int num in numbers)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine("]");
                    }
                    break;

                case 'A':
                    Console.Write("Enter an integer to add: ");
                    int numToAdd = Convert.ToInt32(Console.ReadLine());
                    numbers.Add(numToAdd);
                    Console.WriteLine(numToAdd + " added");
                    break;

                case 'M':
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }
                    else
                    {
                        double sum = 0;
                        foreach (int num in numbers)
                        {
                            sum += num;
                        }
                        double mean = sum / numbers.Count;
                        Console.WriteLine("The mean is " + mean);
                    }
                    break;

                case 'S':
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }
                    else
                    {
                        int min = numbers[0];
                        foreach (int num in numbers)
                        {
                            if (num < min) min = num;
                        }
                        Console.WriteLine("The smallest number is " + min);
                    }
                    break;

                case 'L':
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    }
                    else
                    {
                        int max = numbers[0];
                        foreach (int num in numbers)
                        {
                            if (num > max) max = num;
                        }
                        Console.WriteLine("The largest number is " + max);
                    }
                    break;

                case 'F':
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to search - list is empty");
                    }
                    else
                    {
                        Console.Write("Enter number to find: ");
                        int target = Convert.ToInt32(Console.ReadLine());
                        if (numbers.Contains(target))
                        {
                            Console.WriteLine(target + " is in the list");
                        }
                        else
                        {
                            Console.WriteLine(target + " is not in the list");
                        }
                    }
                    break;

                case 'C':
                    numbers.Clear();
                    Console.WriteLine("List cleared");
                    break;

                case 'Q':
                    Console.WriteLine("Goodbye");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Unknown selection, please try again");
                    break;
            }
        }
    }
}

