using System;

namespace Task3
{
	class program
	{
		static void Main(string[] args)
		{
			var robot = new IRobot[] {
				new Tank (123, "SuperAxe"),
				new Tank (45, "Haudrauf"),
				new Heal (666, "Ariel"),
				new Heal (999, "HealWarSchonDurch"),


			};

			foreach (var a in robot) 
			{	
				
				Console.WriteLine ($"{a.Getseriennummer()},{a.Getname()}");
				a.Updatesn (24*a.Getseriennummer());
				Console.WriteLine ($"{a.Getseriennummer()},{a.Getname()}");
				a.Updatesn (23);
				Console.WriteLine ($"{a.Getseriennummer()},{a.Getname()}");
			}
		
		/*	catch (Exception ex)
			{

				Console.WriteLine($"ERROR: {ex}");
			}
		*/

		}



	}
}

