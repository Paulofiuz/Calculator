using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        static void Sum()
        {

            Console.Clear();
            Console.WriteLine("Enter the first value: ");

            float v1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());


            float result = v1 + v2;
            Console.WriteLine($"Result of the operation: {result}");
        }

        static void subtraction()
        {
            Console.Clear();
            Console.WriteLine("Enter the first value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());
            
            

            float result = v1 - v2;
            Console.WriteLine($"Result of the operation: {result}");

        }

        static void multiplication(){
            Console.Clear();
            Console.WriteLine("Enter the first value: ");

            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;
            Console.WriteLine($"Result of the operation: {result}");

        }

        static void division(){
            Console.WriteLine("Enter the first value: ");

            float v1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());


            float result = v1 / v2;
            Console.WriteLine($"Result of the operation: {result}");
        }
    }

    
}
