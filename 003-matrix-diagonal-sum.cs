using System;

class Program {
    static void Main() {
        int[,] array = new int[3, 3];
        int diagonal_sum = 0;

        Console.WriteLine("Input your matrix entries:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                if (i == j) {
                    diagonal_sum += array[i, j];
                }
            }
        }

        Console.WriteLine("The sum of diagonal is " + diagonal_sum);
    }
}
