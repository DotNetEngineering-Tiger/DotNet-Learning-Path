using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction to Variables and Data Types
            int age = 1000000000;
            double favoriteNumber = 3.14159;
            string name = "John";
            bool lovesProgramming = true;

            Console.WriteLine($"Hello, my name is {name}. I am {age} years old, and my favorite number is {favoriteNumber}.");
            Console.WriteLine($"Do I love programming? {lovesProgramming}");

            // Expanded Deep Dive into Numbers
            long population = 100000000000; // World population example for long
            float temperature = 36.61f; // Body temperature example for float
            decimal accountBalance = 12345.67m; // Bank account balance example for decimal
            var x = age*29000000000;

            //creating new long L and assinging value
            long l = 909090909090;
            //reassigning a value to the already define var X
            x = l;

            Console.WriteLine($"World population: {population}");
            Console.WriteLine($"Normal body temperature: {temperature}°C");
            Console.WriteLine($"Your account balance is: ${accountBalance}");

            double radius = 5.5;
            double areaOfCircle = Math.PI * radius * radius;
            Console.WriteLine($"The area of a circle with radius {radius} is {areaOfCircle}.");

            // Understanding Strings
            string originalString = "C# is fun!";
            string replacedString = originalString.Replace("fun", "awesome");

            var first = "          Kuldip         ";            
            first = first.Trim(); //output "Kuldip"

            Console.WriteLine(replacedString);


            // Expanded Casting and Type Conversion
            string input = "100";
            string secondInput = "500.70";
            int convertedToInt = Convert.ToInt32(input);
            double convertedToDouble = Convert.ToDouble(secondInput);
            Console.WriteLine($"String to int: {convertedToInt}, String to double: {convertedToDouble}");
            var w = int.Parse(input);

            // New conversion examples
            // int to double
            int sampleInt = 100;
            double intToDouble = sampleInt; // Implicit conversion
            Console.WriteLine($"Int to double (implicit): {intToDouble}");

            // double to int (explicit conversion)
            double sampleDouble = 123.456;
            int doubleToInt = (int)(sampleDouble);
            Console.WriteLine($"Double to int (explicit): {doubleToInt}");

            // string to float
            string floatString = "45.67";
            float stringToFloat = float.Parse(floatString);
            Console.WriteLine($"String to float: {stringToFloat}");

            // decimal to double (explicit conversion)
            decimal sampleDecimal = 789.012m;
            double decimalToDouble = (double)sampleDecimal;
            Console.WriteLine($"Decimal to double (explicit): {decimalToDouble}");

            float floatValue = 12.1f;
            double floatToDouble = (double)floatValue;
            double floatToNextDouble = Convert.ToDouble(floatValue);

            var doubleSum = floatValue + floatToNextDouble;
            var doubleToDecimal = (decimal)doubleSum;
            var floatFinal = (float)doubleToDecimal;

            // Exercise: User Input Program (Homework Assignment example)
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your favorite number: ");
            double userFavNumber = Convert.ToDouble(Console.ReadLine());

            int birthYear = DateTime.Now.Year - userAge;
            Console.WriteLine($"Hello {userName}, you are {userAge} years old, you were born in {birthYear}, and your favorite number is {userFavNumber}.");
        }
    }
}

