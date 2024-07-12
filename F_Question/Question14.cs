interface IParent {
	void Start();
}
class Parent {
	public virtual void Start() {
		Console.WriteLine("Parent Start");
	}
}
class Child : Parent, IParent {
	public override void Start() {
		Console.WriteLine("Child Start");
	}
}
class Program {
	static void Main() {
		Parent p  = new Child();
		p.Start();
	}
}