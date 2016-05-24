using System;

namespace Task3
{
	class Heal : IRobot
	{	

		decimal seriennummer;
		string name;

        public decimal Seriennummer
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Heal (decimal dieSNr, string derName)
		{
	
					if(string.IsNullOrWhiteSpace(derName))
						throw new Exception("keine SerienNr.");
					if(dieSNr <0)
						throw new Exception("kein Name");

					seriennummer = dieSNr;
					name = derName;
					Updatesn(dieSNr);


				}
				public decimal Getseriennummer()
				{
					return seriennummer;
				}

				public string Getname() => name; 

				public void Updatesn(decimal neuesn)
				{
					if (neuesn < 0) throw new Exception ("Negativer Wert");
					seriennummer = neuesn;
				}

			


	}
}

