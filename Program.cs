using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Welcome");
            Console.WriteLine("Which operation is to perform?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exit the system");

            Console.WriteLine("/-----------------------------------/");
            Console.WriteLine("Select an option: ");
            short SelectedNumber = short.Parse(Console.ReadLine());

            switch(SelectedNumber){
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division();  break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

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

            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Enter the first value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());
            
            float result = v1 - v2;
            Console.WriteLine($"Result of the operation: {result}");

             Console.ReadKey();
            Menu();
        }

        static void Multiplication(){
            Console.Clear();
            Console.WriteLine("Enter the first value: ");

            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;
            Console.WriteLine($"Result of the operation: {result}");

            Console.ReadKey();
            Menu();
            
        }

        static void Division(){
            Console.WriteLine("Enter the first value: ");

            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 / v2;
            Console.WriteLine($"Result of the operation: {result}");
            
            Console.ReadKey();
            Menu();
        }
    }

    
}
