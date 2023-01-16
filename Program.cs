using System;

namespace converter 
{
    public class Program
    {
        static void Main(string[] args)
        {

            // CM --> INCHES

            Console.Write("Cm: ");
            double cm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"inch: {Convert_To_Inch(cm)}");
            Console.ReadLine();

            // Celsius --> fahrenheit

            Console.Write("Celsius: ");
            double celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Fahrenheit: {Convert_To_Fahrenheit(celsius)}");
            Console.ReadLine();


            // KM --> M

            Console.Write("KM: ");
            double KM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"M: {Convert_To_Meter(KM)}");
            Console.ReadLine();


            // Fahrenheit --> Celsius

            Console.Write("Fahrenheit: ");
            double fahrenheit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Celsius: {Convert_To_Celsius(fahrenheit)}");
            Console.ReadLine();



            // meter --> feet

            Console.Write("Meter: ");
            double meter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Feet: {Convert_To_Feet(meter)}");
            Console.ReadLine();



        }

        static double Convert_To_Inch(double cm)
        {
            return cm / 2.54;
        }

        static double Convert_To_Fahrenheit(double celsius)
        {
            return (celsius * 9 / 5) +32;
        }

        static double Convert_To_Meter(double KM)
        {
            return KM * 1000;
        }

        static double Convert_To_Celsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double Convert_To_Feet(double meter)
        {
            return meter * 3.281;
        }


    }
}