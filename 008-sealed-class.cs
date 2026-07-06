using System;

sealed public class Person {
    public void display() {
        Console.Log("This is a sealed class.");
    }
}

public class Child : Person {
    public void display() {
        Console.Log("This is not allowed.");
    }
}

class Program {
    static void Main() {
        Child obj = new Child();
    }
}
