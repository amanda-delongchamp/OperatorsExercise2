using System;

namespace OperatorsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for input
            Console.WriteLine("What is the radius of your circle?");
            //convert string input into a number
                var radius = int.Parse(Console.ReadLine());
            //call method to perform calculation and then print results
            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}");
        }

        public static double AreaOfCircle(int radius)
        {
            //calculate area of circle based on input from user
            return Math.PI * radius * radius;
        }
    }
}
