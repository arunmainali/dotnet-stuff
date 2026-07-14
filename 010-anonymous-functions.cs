using System;

class Program {
    static void Main() {
        Func<int, int, int> multiply = (a, b) => {
            return a * b;
        };

        Console.WriteLine(multiply(2, 3));
        Console.WriteLine(multiply(5, 5));
    }
}
