using System;

interface A {
    void sum();
    void sub();
}

interface B {
    void prod();
}

class Program : A, B {
    public void sum() {
        Console.WriteLine("Sum");
    }

    public void sub() {
        Console.WriteLine("Sub");
    }

    public void prod() {
        Console.WriteLine("Prod");
    }

    static void Main() {
        A obj_a = new Program();
        B obj_b = new Program();
        Program obj_p = new Program();

        obj_a.sum();
        obj_b.prod();
    }
}
