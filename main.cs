// Created by: Joanne Santhosh
// Created on: Apr 2022
//
// This program converts the temperature from fahrenheit to celsius

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program converts the temperature from fahrenheit to celsius
        int temperatureInFahrenheit;
        int celsius;

        // input
        Console.WriteLine("This program converts the temperature from fahrenheit to celsius.");
        Console.WriteLine("");

        Console.WriteLine("Enter the temperature in fahrenheit.");
        temperatureInFahrenheit = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("");

        // process
        celsius = ((temperatureInFahrenheit - 32) * 5 / 9);
        Console.WriteLine("");

        // output
        Console.Write("The temperature in celsius is = " + celsius + "°");
        Console.WriteLine("\nDone.");
    }
}
