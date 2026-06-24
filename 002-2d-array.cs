using System;

class Program {
    static void Main() {
        int[,] array = new int[3, 3];

        Console.WriteLine("Input your matrix entries:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("The matrix you entered is:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine("");
        }
    }
}
