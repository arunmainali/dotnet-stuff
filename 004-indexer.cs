using System;

class Student {
    private int[] id = new int[5];
    private int[] another_id = new int[5];

    public int this[int index] {
        set {
            if (index > 0 && index < another_id.Length) {
                another_id[index] = value;
            }
        }

        get {
            return another_id[index];
        }
    }

    static void Main() {
        Student student = new Student();
        student[0] = 101;
        student[1] = 102;
        Console.WriteLine(student[0]);
        Console.WriteLine(student[1]);
    }
}
