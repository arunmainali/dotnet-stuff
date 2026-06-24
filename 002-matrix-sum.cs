using System;

class Program {
    static void Main() {
        int[,] array1 = new int[3, 3];
        int[,] array2 = new int[3, 3];
        int[,] array_sum = new int[3, 3];

        Console.WriteLine("Input your matrix 1 entries:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                array1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Input your matrix 2 entries:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                array2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("The sum you entered is:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                array_sum[i, j] = array1[i, j] + array2[i, j];
                Console.Write(array_sum[i, j] + "\t");
            }
            Console.WriteLine("");
        }
    }
}
