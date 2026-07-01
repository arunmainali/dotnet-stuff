using System;

class Program {
    struct Student {
        public int id;
        public string name;

        public Student(int id, string name) {
            this.id = id;
            this.name = name;
        }

        public void displayValues() {
            Console.WriteLine(id + ", " + name);
        }
    }

    static void Main() {
        Student student = new Student(10, "Arun");

        student.displayValues();
    }
}
