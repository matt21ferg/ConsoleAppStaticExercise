using System;

namespace ConsoleAppStaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(69);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(25);


            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");



        }
    }
}
