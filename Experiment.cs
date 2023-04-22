using System;

class TestClass
{
	public void TestMethod()
	{
		Console.WriteLine("Test1");
	}

}

class MainClass
{
	public static void Main(String[] args)
	{
		TestClass obj = new TestClass();
		obj.TestMethod();
	}
}