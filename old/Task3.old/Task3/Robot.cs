using System;

namespace Task3
{
	public class Robot
	{
			decimal seriennummer;
			string name;

			public robot(decimal dieSNr, string derName)
			{
				if(string.IsNullOrWhiteSpace(derName))
					throw new Exception("keine SerienNr.");
				if(dieSNr <0)
					throw new Exception("kein Name");

				seriennummer = dieSNr;
				//name = derName;
				Updatesn(dieSNr);


			}
			public decimal Getseriennummer()
			{
				return seriennummer;
			}

			public string Getname() => name; //das selbe wie return name;

			public void Updatesn(decimal neuesn)
			{
				if (neuesn < 0) throw new Exception ("Negativer Wert");
				seriennummer = neuesn;

			}


		}
	}


