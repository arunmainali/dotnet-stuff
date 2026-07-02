using System;

abstract class AbstractClass {
    public abstract void sayHello();
    public abstract void sayHi();
}

class AbstractImplementation : AbstractClass {
    public override void sayHello() {
        Console.WriteLine("Hello");
    }

    public override void sayHi() {
        Console.WriteLine("Hi");
    }

    static void Main() {
        AbstractImplementation obj = new AbstractImplementation();

        obj.sayHello();
        obj.sayHi();
    }
}
