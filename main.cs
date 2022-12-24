// Created by: Youngwook
// Created on: NOV 2022
//
// This function gets user number and do proper calculation

using System;

class Program
{
    public static void Main(string[] args)
    {
        // input
        double number;
        double count = 0;
        double answer = 0;
        double denominator = 1;
        double sign = 1;

        Console.WriteLine("This program gets user number to calculate pi.");

        Console.Write("Enter calculation number : "); number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The count is : " + count);
        Console.WriteLine("The denominator is : " + denominator);
        // output
        while (number - 1 >= count)
        {
            answer = answer + (4 / denominator);
            sign = (Math.Abs(denominator) / denominator) * -1;
            denominator = (Math.Abs(denominator) + 2) * sign;

            count = count + 1;
            Console.WriteLine("The count is : " + count);
            Console.WriteLine("The denominator is : " + denominator);
        }

        Console.WriteLine("\n\nThe answer is : " + answer.ToString("0.00"));
        Console.WriteLine("\ndone.");
    }
}
