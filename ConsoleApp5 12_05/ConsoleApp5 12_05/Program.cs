using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace ConsoleApp5_12_05
{
    internal class Program
    {

        static List<int> GetInitialSeries(string[] args)
        {
            List<int> series = new List<int>();

            if (args.Length >= 3)
            {
                bool allPositive = true;
                foreach (string arg in args)
                {
                    if (int.TryParse(arg, out int num) && num > 0)
                    {
                        series.Add(num);
                    }
                    else
                    {
                        allPositive = false;
                        break;
                    }
                }

                if (allPositive)
                {
                    return series;
                }
            }

            Console.WriteLine("Enter at least 3 positive numbers separated by spaces:");
            while (true)
            {
                string input = Console.ReadLine();
                string[] inputParts = input.Split(' ');
                series.Clear();
                bool allValid = true;

                foreach (var part in inputParts)
                {
                    if (int.TryParse(part, out int num) && num > 0)
                    {
                        series.Add(num);
                    }
                    else
                    {
                        allValid = false;
                        break;
                    }
                }

                if (series.Count >= 3 && allValid)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter at least 3 positive numbers:");
                }
            }

            return series;
        }
        static void showMenu(List<int> series)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("chose an option ");
                Console.WriteLine("1. input new series");
                Console.WriteLine("2. Display series as order");
                Console.WriteLine("3. Display series in reverse order");
                Console.WriteLine("4. Display series sorted");
                Console.WriteLine("5. Display series max");
                Console.WriteLine("6. Display series min");
                Console.WriteLine("7. Display series average");
                Console.WriteLine("8. Display series sum");
                Console.WriteLine("9. Display series count");
                Console.WriteLine("0.exit ");
                Console.WriteLine("Enter your choice: ");
                string choice = Console.ReadLine();
                
                switch(choice)
                {
                    case "1":
                        series = GetInitialSeries(new string[0]);
                        break;
                    case "2":
                        Displayseries(series);
                        break;
                    case "3":
                        DisplayseriesReverse(series);
                        break;
                    case "4":
                        List<int> sorted = SortedSeries(series);
                        Displayseries(sorted);
                        break;
                    case "5":
                        Console.WriteLine($"Max:  {GetMax(series)}");
                        break;
                    case "6":
                        Console.WriteLine($"Min:  { GetMin(series)}");
                        break;
                    case "7":
                        Console.WriteLine($"Average:  { GetAverage(series)}");
                        break;
                    case "8":
                        Console.WriteLine($"Sum:  { GetSum(series)}");
                        break;
                    case "9":
                        Console.WriteLine($"Count:  { GetCount(series)}");
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("good bye");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
            }
        }
        static void Displayseries(List<int> series)
        {
            Console.WriteLine("Series in order:");
            foreach (int num in series)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void DisplayseriesReverse(List<int> series)
        {
            Console.WriteLine("Series in reverse order:");
            for (int i = series.Count - 1; i >= 0; i--)
            {
                Console.Write(series[i] + " ");
            }
            Console.WriteLine();
        }
        static List<int> SortedSeries(List<int> series)
        {
            List<int> sorted = new List<int>(series);
            for (int i = 0; i < sorted.Count - 1; i++)
            {
                for (int j = 0; j > sorted.Count - i - 1; j++)
                {
                    if (sorted[j] > sorted[j + 1])
                    {
                        int temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
                
            }
            return sorted;
        }
        static int GetMax(List<int> series)
        {
            int max = series[0];
            foreach (int num in series)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        static int GetMin(List<int> series)
        {
            int min = series[0];
            foreach (int num in series)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }
        static double GetAverage(List<int> series)
        {
            double sum = 0;
            foreach (int num in series)
            {
                sum += num;
            }
            return sum / series.Count;
        }
        static int GetSum(List<int> series)
        {
            int sum = 0;
            foreach (int num in series)
            {
                sum += num;
            }
            return sum;
        }
        static int GetCount(List<int> series)
        {
            int count = 0;
            foreach (int num in series)
            {
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {

            List<int> series = GetInitialSeries(args);
            showMenu(series);

        }






    }

}
