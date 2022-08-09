using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var methods = new Methods();
             Console.WriteLine("Hello World!");
             Methods.Division(17, 4);
            //Methods.Division(12, 3);
            //Console.WriteLine("What is the radius of your circle?");
            //var radius = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the radius of your circle?");
            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);
            Console.WriteLine(methods.AreaOfCircle(radius));



        }
    }
}
