using System;
using System.Threading;

namespace oefening
{	
	public class Calculator{
		private double Getal1{get; set;}
		private double Getal2{get; set;}
		public Calculator(double getal1, double getal2) 
		{
			this.Getal1 = getal1;
			this.Getal2 = getal2;
		}
		public double multiply()
		{
			return this.Getal1 * this.Getal2;
		}

		public double add()
		{
			return this.Getal1 + this.Getal2;
		}

		public double subtract()
		{
			return this.Getal1 - this.Getal2;
		}

		public double divide()
		{
			return this.Getal1 / this.Getal2;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			var calculator = new Calculator(8,3);

			bool isDocent = false;
			string voornaam = "";
			string familienaam  = "";
			try 
			{
				voornaam = args[1];
				familienaam = args[2];
				if (args[0] == "docent")
				{
					isDocent = true;
				}
			}
			catch (System.Exception)
			{
				SchrijfLog("Parameters weren't correct.");
				SchrijfLog("Voornaam:");
				voornaam = Console.ReadLine();
				SchrijfLog("Achtenaam: ");
				familienaam = Console.ReadLine();
				SchrijfLog("Ben je een student? Y/N");
				string docentResponse = Console.ReadLine();
				if (docentResponse == "Y") 
				{
					isDocent = true;
				} 
			}
			SchrijfLog(GenereerAccount(voornaam, familienaam, isDocent));
		}
		
		static void SchrijfLog(string output) => Console.WriteLine(output);

		static void SchrijfLog(double output) => Console.WriteLine(output.ToString());

		static int GenereerWillekeurigGetal(int min, int max) 
		{
			Random r = new Random();
			return r.Next(min, max);
		}

		static string GenereerLottoGetallen()
		{
			string output = "";
			for (int i = 0; i < 6; i++)
			{
				output += " " + GenereerWillekeurigGetal(1,45);
			}
			return output;
		}

		static void LottoTrekking()
		{
			SchrijfLog("Lotto wordt getrokken");
			for (int i = 0; i < 6; i++)
			{
				SchrijfLog(GenereerWillekeurigGetal(1,45));
				Thread.Sleep(5000);
			}
		}

		static string genereerEuroMillions()
		{
			string getallen = "";
			string sterren = "";
			for (int i = 0; i < 5; i ++)
			{
				getallen += " " +  GenereerWillekeurigGetal(1,50);
			}
			for (int i = 0; i < 2; i ++)
			{
				sterren += " " +  GenereerWillekeurigGetal(1,9);
			}
			return "getallen: " + getallen + " | sterren: " + sterren;
		}

		static void rumble(int min, int max) 
		{
			for (int i = 0; i < 15; i++)
			{
				SchrijfLog(GenereerWillekeurigGetal(min, max));
				Console.SetCursorPosition(0, Console.CursorTop - 1);
				Thread.Sleep(200);
			} 
		}

		static void EuroMillion()
		{
			SchrijfLog("EuroMillions wordt getrokken");
			SchrijfLog("Getallen");
			for (int i = 0; i < 5; i++)
			{
				rumble(1,50);
				SchrijfLog(GenereerWillekeurigGetal(1,50));
			}
			SchrijfLog("Sterren");
			for (int i = 0; i < 2; i++)
			{
				rumble(1,9);
				SchrijfLog(GenereerWillekeurigGetal(1,9));
				
			}
		}

		static string GenereerString(string input, int lengte)
		{
			return input.Substring(0, lengte);
		}

		static string GenereerAccount(string voornaam, string familienaam, bool isDocent)
		{
			if (isDocent)
			{
				return String.Format("De account van {0} {1} is: {2}", voornaam, familienaam, String.Format("{0}{1}@student.arteveldehs.be", GenereerString(voornaam.ToLower(),10), GenereerString(familienaam.ToLower(),10)));
			} else {
				return String.Format("De account van {0} {1} is: {2}", voornaam, familienaam, String.Format("{0}{1}@student.arteveldehs.be", GenereerString(voornaam.ToLower(),4), GenereerString(familienaam.ToLower(),4)));
			}
			
		}
    	}
}
