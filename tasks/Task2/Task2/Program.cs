using System;

namespace Task2
{
	class program
	{
		static void Main(string[] args)
		{
			robot a = new robot (25, "Die SNr ");
			robot b = a;
			Console.WriteLine ($"{a.Getseriennummer()},{a.Getname()}");
			a.Updatesn (24);
			Console.WriteLine ($"{a.Getseriennummer()},{a.Getname()}");
			a.Updatesn (23);
		}

	}
}
