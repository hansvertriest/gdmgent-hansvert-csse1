using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace oefening7
{
	public class Gebruiker : Persoon
	{
		// velden
		protected string gebruikersnaam;
		protected string wachtwoord;
		protected string login;

		// Properties
		public string Gebruikersnaam
		{
			get
			{
				return gebruikersnaam;
			}
		}
		public string Login
		{
			get
			{
				return login;
			}
		}
		public string Wachtwoord
		{
			get 
			{
				return wachtwoord;
			}
		}
		// Constructors
		public Gebruiker(){}	

		public Gebruiker(string naam, string voornaam, char geslacht)
		{
			this.voornaam = voornaam;
			this.Naam = naam;
			this.Geslacht = geslacht;
			this.wachtwoord = GenereerWachtwoord();
			this.login = GenereerLogin(this.Naam, this.voornaam);
			this.gebruikersnaam = GenereerGebruikersNaam(this.Naam, this.voornaam);
		}
		public Gebruiker(string naam, string voornaam, char geslacht, string wachtwoord, string gebruikersnaam, string login)
		{
			this.voornaam = voornaam;
			this.Naam = naam;
			this.Geslacht = geslacht;
			this.wachtwoord = wachtwoord;
			this.login = login;
			this.gebruikersnaam = gebruikersnaam;
		}

		// Methods

		// hashing methods

		 public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

		public string GenereerString(string input, int lengte)
		{
			return input.Substring(0, lengte);
		}
		public void LogGegevens()
		{
			Console.WriteLine("Gebruikersnaam: " + this.Gebruikersnaam);
			Console.WriteLine("login: " + this.Login);
			Console.WriteLine("Gehasht wachtwoord: " + this.Wachtwoord);
		}
		virtual public string GenereerWachtwoord() 
		{
			char[] array = {'g', 'e', 'b', 'r', 'u', 'i', 'k', 'e', 'r'};
			Random rnd=new Random();
			char[] MyRandomArray = array.OrderBy(x => rnd.Next()).ToArray();
			Console.WriteLine("Ongehasht wachtwoord: " + string.Join("", MyRandomArray));  
			return GetHashString(string.Join("", MyRandomArray));
		}
		virtual public string GenereerLogin(string naam, string voornaam) 
		{
			return String.Format("{0}{1}@arteveldehs.be", GenereerString(voornaam.ToLower(),2), GenereerString(naam.ToLower(),3));
		}
		virtual public string GenereerGebruikersNaam(string naam, string voornaam) 
		{
			return String.Format("{0}{1}", GenereerString(voornaam.ToLower(),2), GenereerString(naam.ToLower(),3));
		}
		
		
	}
}