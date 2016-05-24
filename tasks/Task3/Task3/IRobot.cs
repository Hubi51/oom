using System;

namespace Task3
{
	interface IRobot
	{
			
		decimal Seriennummer { get; }
		string Name { get; }

        void Updatesn(decimal sn);
        decimal Getseriennummer();
        string Getname();
    }
}

