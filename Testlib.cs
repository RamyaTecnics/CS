//Test dll.
//>csc /r:TestClass.dll Testlib.cs

using System;
using mylib;

class Testlib
{
	public static void Main(String[] args)
	{
		math1 oTest = new math1();
		oTest.Add();
		math2.Sub();
	}
}