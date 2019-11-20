using System;

namespace oefening7
{
	public class Persoon
	{
		// velden
		public string voornaam;
		protected char geslacht;
		public string naam;

		// properties
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

		// constuctor
		public Persoon() 
		{

		}
		public Persoon(string naam, string voornaam)
		{
			this.Naam = naam;
			this.voornaam = voornaam;
		}
		public Persoon(string naam, string voornaam, char geslacht)
		{
			this.Naam = naam;
			this.voornaam = voornaam;
			this.Geslacht = geslacht;
		}
		// methods
		public void logOutput()
		{
			Console.WriteLine(string.Format("Output: Voornaam {0}, Familienaam: {1}, Geslacht: {2}, geslacht: {3}", this.voornaam, this.Naam, Geslacht, this.geslacht));
		}
	}
}