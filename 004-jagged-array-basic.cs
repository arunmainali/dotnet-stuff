using System;

class Program {
    static void Main() {
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = new int[2] {3, 5};
        jaggedArray[1] = new int[4] {1, 2, 3, 4};
        jaggedArray[2] = new int[3] {100, 200, 300};

        for (int i = 0; i < jaggedArray.Length; i++) {
            for (int j = 0; j < jaggedArray[i].Length; j++) {
                Console.Write(jaggedArray[i][j] + "\t");
            }
            Console.WriteLine("");
        }
    }
}
