using System;

class Program {
    int Add(int a, int b) {
        return (a + b);
    }

    int Add(int a, int b, int c) {
        return (a + b + c);
    }

    static void Main() {
        Program obj = new Program();

        Console.WriteLine(obj.Add(1, 2));
        Console.WriteLine(obj.Add(1, 2, 3));
    }
}
