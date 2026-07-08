using System;

namespace ConsoleApp
{
    public delegate void DelEventHandler();

    class Program
    {
        public static event DelEventHandler Add;

        static void Main(string[] args)
        {
            Add += Initiate;
            Add += Welcome;

            Console.WriteLine("Press Enter to raise the event...");
            Console.ReadLine();

            Add?.Invoke();

            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }

        static void Initiate()
        {
            Console.WriteLine("Event Initiated");
        }

        static void Welcome()
        {
            Console.WriteLine("Welcome! The event has been received.");
        }
    }
}
