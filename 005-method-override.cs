using System;

class Parent {
	public virtual void display() {
		Console.WriteLine("Hello from parent");
	}
}

class Child : Parent {
	public override void display() {
		Console.WriteLine("Hello from child");
	}
}

class Program {
	static void Main() {
		Parent parent_obj = new Parent();
		Child child_obj = new Child();

		parent_obj.display();
		child_obj.display();
	}
}
