using System;

class Program {

    static void Main() {
      int[,] matrix1 = new int[3, 3];
        int[,] matrix2 = new int[3, 3];
        int[,] matrix_product = new int[3, 3];

        Console.WriteLine("Input the entries for matrix 1:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Input the entries for matrix 2:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                for (int k = 0; k < 3; k++) {
                    matrix_product[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write(matrix_product[i, j]);
            }
            Console.WriteLine();
        }
    }
}
