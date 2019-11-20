using System;
using System.Linq;

namespace oefening7
{
	public class Student : Gebruiker
	{
		//velden 
		public string voornaam;
		protected char geslacht;
		//properties
		public char Geslacht {
			get
			{
				return geslacht;
			}

			set
			{
				if(value == 'M' | value == 'O' | value == 'V' | value == 'm' | value == 'o'| value == 'v')
				{
					geslacht = value;
				}
			}
		}

		public string Naam {
			set
			{
				naam = value;
			}
			get
			{
				return naam;
			}
		}

		public Student(){}

		public Student(string naam, string voornaam)
		{
			this.Naam = naam;
			this.voornaam = voornaam;
			this.login = GenereerLogin(this.Naam, this.voornaam);
			this.gebruikersnaam = GenereerGebruikersNaam(this.Naam, this.voornaam);
			this.wachtwoord = GenereerWachtwoord();
		}
		
		public Student(string naam, string voornaam, char geslacht) : base( naam,  voornaam,  geslacht)
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
			return String.Format("{0}{1}@student.arteveldehs.be", GenereerString(voornaam.ToLower(),4), GenereerString(naam.ToLower(),4));
		}

		override public string GenereerGebruikersNaam(string naam, string voornaam) 
		{
			return String.Format("{0}{1}", GenereerString(voornaam.ToLower(),4), GenereerString(naam.ToLower(),4));
		}
		override public string GenereerWachtwoord() 
		{
			char[] MyArray = {'s', 't', 'u', 'd', 'e', 'n', 't'};
			Random rnd=new Random();
			char[] MyRandomArray = MyArray.OrderBy(x => rnd.Next()).ToArray();  
			Console.WriteLine(string.Join("", MyRandomArray));  
			return GetHashString(string.Join("", MyRandomArray));
		}
		
	}
}