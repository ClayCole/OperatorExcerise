using System;
using System.Threading;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Console.WriteLine("This will include Excerise 1 & 2");


            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            //Console.WriteLine(a + "/" + b + " is " + quotient + " remainder" + remainder);
            // You use the + to conqentanit (puts together) the String

            //or

            Console.WriteLine($"{a}/{b} is {quotient} with a remainder of {remainder}");
            // I prefer this style aka String interpolation

            Thread.Sleep(3000);
            Console.WriteLine("Are you ready for the next exercise? Might need a Circle");
            Console.ReadLine();

            Console.WriteLine("What is the Radius of your Circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine("this is The Area of your Circle:");
            Console.WriteLine(AreaOfCircle(radius));


        }
        // to find Pi in the future ...type MATH.PI
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;

        }







    }
}
