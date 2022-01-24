using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStaticExercise
{
   public static class TempConverter
    {

        static TempConverter()
        {

        }

         public static  double FahrenheitToCelsius(double Fahtrenheit)
        {
            var result = (Fahtrenheit - 32) / 1.8;
            return result;
        }

      public  static double CelsiusToFahrenheit(double Celsius)
        {
            return (Celsius * 9) / 5 + 32;
        }



    }
}
