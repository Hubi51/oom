using System;

namespace lesson3
{
	class MainClass
	{

		static int[] MAP(int[] data, Func<int, intf)
		{
			var result = new int [data.Length];

			!!!!
			result;
		}

		static void Main(string [] args)
		{
			int[] data = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			var data2 = Map (data, x => x * x);

			foreach (var x in data2)
				Console.WriteLine (x);
			Console.WriteLine ("---");



			var data3 = Map (data, x => x * x * x);

			foreach (var x in data3)
				Console.WriteLine (x);
			Console.WriteLine ("---");


			Func<int, int> f = Square;
			Test (Cube);
		}

		static void Test(Func<int, int>g)
		{
			Console.WriteLine (g(5));

		}
	}
}
