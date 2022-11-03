// Created by:sophie
// Created on: oct 2020
//
//this program calculates fahrenheit to celcius

using System;

class Program
{
    public static void Main(string[] args)
    {
       int fahrenheit;
       double celcius;

        Console.WriteLine("calculates the fahrenheit to celcius");
        Console.WriteLine("");

        Console.Write("Enter fahrenheit (cm): ");
        fahrenheit = Convert.ToInt32(Console.ReadLine());

        celcius = (fahrenheit - 32) * 5.00 / 9.00;
          
        Console.WriteLine("");
        Console.WriteLine("in celcius is: " + celcius + " °C. ");

        Console.WriteLine("\nDone.");
    }
}