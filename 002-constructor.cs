using System;

class Student {
    int rollNo;
    int age;
    float salary;

    Student(int rollNo_p, int age_p, float salary_p) {
        rollNo = rollNo_p;
        age = age_p;
        salary = salary_p;
    }

    void display() {
        Console.WriteLine("Roll No.: " + rollNo);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Salary: " + salary);
    }

    static void Main() {
        Student student1 = new Student(1, 21, 1900);
        Student student2 = new Student(2, 15, 2000);

        student1.display();
        student2.display();
    }
}
