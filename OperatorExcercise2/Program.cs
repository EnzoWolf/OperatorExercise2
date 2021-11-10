using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExcercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get radius of circle from user
            Console.WriteLine("What is the radius of your circle:");
            var radius = double.Parse(Console.ReadLine());

            //Call AreaOfCircle method
            var areaTotal = AreaOfCircle(radius);

            //Output the area of the circle
            Console.WriteLine($"\r\nThe area of a circle with the radius of {radius} is {areaTotal}.");

            Console.ReadKey();

        }

        //Method to calculate the area of a circle
        public static double AreaOfCircle(double radius) //AreaOfCircle was declared in the C# Operators Excercise document
        {
            var circleArea = Math.PI * (radius * radius); //Formula for calculating the area of a circle 
            return circleArea;
        }
    }
}
