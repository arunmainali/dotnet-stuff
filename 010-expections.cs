using System;

class Program {
    static void Main() {
        try {
            int a = 10;
            int b = 0;
            int div = a / b;
            Console.WriteLine("No problem!");
        }
        catch (DivideByZeroException e) {
            Console.WriteLine("Division by zero");
            Console.WriteLine(e.Message);
        }
        try {
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine(nums[5]);
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}
