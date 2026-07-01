using System;

class Program {
    enum Year {
        January = 10,
        Februray = 15,
        March = 20,
    }

    static void Main() {
        foreach(string stringYear in Enum.GetNames(typeof(Year))) {
            Console.WriteLine(stringYear);
        }

        Console.WriteLine("January's value is " + (int)Year.January);
    }
}
