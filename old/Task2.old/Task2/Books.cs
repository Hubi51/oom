using System;

namespace Task2
{
	public class Books
	{
		string titel;
		decimal isbn;
		decimal preis;

		if(string.IsNullOrWhiteSpace(derTitel)) 
			throw new Exception("Leerer Titel");
		if(string.IsNullOrWhiteSpace(derIsbn))
			throw new Exception("Leerer ISBN");
		if(derPreis <0)
			throw new Exception("Negativer Preis");

		titel = derTitel;
		isbn = derIsbn;
		preis = derPreis;


		public Books ()
		{
		}
	}
}

