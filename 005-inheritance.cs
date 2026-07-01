using System;

class Program
{
    class Parent
    {
        protected int a = 5;
        protected int b = 10;

        int sum;

        public Parent()
        {
            sum = a + b;
        }

        protected void display_sum()
        {
            Console.WriteLine(sum);
        }
    }

    class Child : Parent
    {
        int product;

        public Child()
        {
            product = a * b;
        }

        public void Show()
        {
            display_sum();
            Console.WriteLine(product);
        }

        static void Main()
        {
            Child obj = new Child();
            obj.Show();
        }
    }
}
