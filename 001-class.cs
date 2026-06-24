using System;

namespace ConsoleApp
{
    class Arun {
        Arun() {
            Console.WriteLine("Hello from constructor!");
        }

        void func1() {
            Console.WriteLine("Hello from func1");
        }

        static void Main(string[] args) {
            Arun arun = new Arun();
            arun.func1();
      }
    }
}
