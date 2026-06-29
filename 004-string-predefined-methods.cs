using System;

class Program {
    static void Main() {
        // Split method
        string commaString = "Arun,Ram,Hari";
        string spaceString = "Arun Ram Hari";

        string[] commaSplit = commaString.Split(",");
        string[] spaceSplit = spaceString.Split(" ");

        for (int i = 0; i < commaSplit.Length; i++) {
            Console.WriteLine(commaSplit[i]);
        }
        for (int i = 0; i < spaceSplit.Length; i++) {
            Console.WriteLine(spaceSplit[i]);
        }

        // Substring method
        string someString = "Hello from Arun!";
        Console.WriteLine(someString.Substring(3));

        // Remove method
        Console.WriteLine(someString.Remove(5, 8));

        // Concat method
        string string1 = "Hello";
        string string2 = "Hi";
        Console.Write(string.Concat(string1, string2));
    }
}
