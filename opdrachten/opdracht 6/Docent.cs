using System;
using System.Linq;

namespace opdracht_6
{
	public class Docent : Gebruiker
	{
		//velden
		//properties
		//constructors
		public Docent(string naam, string voornaam, char geslacht) : base( naam,  voornaam,  geslacht)
		{
			this.Naam = naam;
			this.voornaam = voornaam;
			this.Geslacht = geslacht;
			this.login = GenereerLogin(this.Naam, this.voornaam);
			this.gebruikersnaam = GenereerGebruikersNaam(this.Naam, this.voornaam);
			this.wachtwoord = GenereerWachtwoord();
		}
		//methods
		override public string GenereerLogin(string naam, string voornaam) 
		{
			return String.Format("{0}{1}@arteveldehs.be", GenereerString(voornaam.ToLower(),4), GenereerString(naam.ToLower(),2));
		}

		override public string GenereerGebruikersNaam(string naam, string voornaam) 
		{
			return String.Format("{0}{1}", GenereerString(voornaam.ToLower(),4), GenereerString(naam.ToLower(),2));
		}
		override public string GenereerWachtwoord() 
		{
			char[] MyArray = {'d', 'o', 'c', 'e', 'n', 't'};
			Random rnd=new Random();
			char[] MyRandomArray = MyArray.OrderBy(x => rnd.Next()).ToArray();  
			Console.WriteLine(string.Join("", MyRandomArray));  
			return GetHashString(string.Join("", MyRandomArray));
		}
		
	}

	
}