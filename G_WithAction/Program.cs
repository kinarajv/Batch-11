﻿//public delegate void MyDelegate(int a, int b);
class Program {
	static void Main() {
		Action<int,int> del = Add;
		del.Invoke(3,4);
	}
	static void Add(int a, int b) {
		Console.WriteLine(a+b);
	}
}