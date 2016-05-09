using System;

namespace Task2
{
	class program
	{
		static void Main(string[] args)
		{
			robot a = new robot ("Die SNr ", 25);
			robot b = a;
			Console.WriteLine ($"{a.Getseriennummer()},{a.Getname()}");
			a.Updatename ("Affe");
			Console.WriteLine ($"{a.Getseriennummer()},{a.Getname()}");
		}

	}
}
