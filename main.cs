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
        Console.WriteLine("This program converts the temperature from fahrenheit to celsius.");
        Console.WriteLine("");

        Console.WriteLine("Enter the temperature in fahrenheit.");
        temperatureInFahrenheit = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("");
        celsius = ((temperatureInFahrenheit - 32) * 5 / 9);
        Console.WriteLine("");
        Console.Write("The temperature in celsius is = " + celsius + "°");

        Console.WriteLine("\nDone.");
    }
}