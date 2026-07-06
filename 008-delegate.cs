using System;

public delegate void operation(int x, int y);

public class Calculation {
    public static void Add(int a, int b) {
        Console.WriteLine(a + b);
    }

    public static void Sub(int a, int b) {
        Console.WriteLine(a - b);
    }

    public static void Prod(int a, int b) {
        Console.WriteLine(a * b);
    }
}

class Program {
    static void Main() {
        operation obj = Calculation.Add;
        obj += Calculation.Sub;
        obj += Calculation.Prod;

        obj(10, 5);
    }
}
