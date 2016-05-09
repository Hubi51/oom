using System;

namespace Task2
{
	class robot
	{
		string seriennummer;
		decimal name;

		public robot(string dieSNr, decimal derName)
		{
			if(string.IsNullOrWhiteSpace(dieSNr))
				throw new Exception("keine SerienNr.");
			if(derName <0)
				throw new Exception("kein Name");
			
			seriennummer = dieSNr;
			//name = derName;
			Updatename(derName);


		}
		public string Getseriennummer()
		{
			return seriennummer;
		}

		public decimal Getname() => name; //das selbe wie return name;
		{
			
		}

		public void Updatename(decimal neuername)
		{
			if (neuername < 0) throw new Exception ("Negativer Wert");
			{
				
			}

		}


	}
}

