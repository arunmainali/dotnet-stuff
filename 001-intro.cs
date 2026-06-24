using System;

namespace ConsoleApp
{
    class Program {
        static void Main(string[] args) {
            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();

            // Console.Write("Enter your age: ");
            // int age = int.Parse(Console.ReadLine());

            // Console.WriteLine("Your name is " + name + ".");
            // Console.WriteLine("You are " + age + " years old.");

            // int num = 5;
            // Console.WriteLine("{0} and {1} and {2}", name, age, num);

            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.Write("{0} + {1} = {2}", num1, num2, sum);
        }
    }
}
