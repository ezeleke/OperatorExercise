using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorExercise
{
    internal class Methods
    {
        
        public static int Addition(int a, int b)
        {
             a = 17;
             b = 4;
            int sum;
            sum = a + b;
            return sum;
        }
        public static int Multiply(int a, int b) 
        {
            int total;
            total = a * b;
            return total;
        }
        public static void Division(int a, int b) 
        {             
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b== 4) 
            {
                Console.WriteLine($"{a} is == to {a}");
                Console.WriteLine($"{a} /= {b} is {quotient} remainder of {remainder}");
               
            }
           
        }
        public static double AreaOfCircle(double radius) 
        {
             
            return Math.PI * Math.Pow(radius, 2);

            
            
           


        }
    }
}
