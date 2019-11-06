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
			// get args
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

			SchrijfLog(add(5,6));
			SchrijfLog(subtract(8, 5));
			SchrijfLog(divide(8,4));
			SchrijfLog(multiply(5,3));
			SchrijfLog(modulo(9,2));
			SchrijfLog(higher(7));
			SchrijfLog(lower(8));

			SchrijfLog(GenereerWillekeurigGetal());
			SchrijfLog(GenereerWillekeurigGetalLimieten(0,80));

			SchrijfLog(GenereerLottoGetallen());
			LottoTrekking();
			SchrijfLog(genereerEuroMillions());
			EuroMillion();

			SchrijfLog(GenereerAccount(voornaam, familienaam, isDocent));

			if(ibanValidator("BE07 7390 1412 0066"))
			{
				SchrijfLog("BE07 7390 1412 0066 is a real IBAN");
			}
			else 
			{
				SchrijfLog("BE07 7390 1412 0066 is fake");
			}

			Fibonacci();
			Faculteit();
		}
		
		static void SchrijfLog(string output) => Console.WriteLine(output);

		static void SchrijfLog(double output) => Console.WriteLine(output.ToString());

		static void getArgs()
		{

		}

		// calculator 

		static double multiply(double getal1, double getal2)
		{
			return getal1 * getal2;
		}

		static double add(double getal1, double getal2)
		{
			return getal1 + getal2;
		}

		static double subtract(double getal1, double getal2)
		{
			return getal1 - getal2;
		}

		static double divide(double getal1, double getal2)
		{
			return getal1 / getal2;
		}

		static double modulo(double getal1, double getal2)
		{
			return getal1 % getal2;
		}

		static int higher(int getal)
		{
			return getal += 1;
		}

		static int lower(int getal)
		{
			return getal += 1;
		}
		
		// random

		static int GenereerWillekeurigGetal() 
		{	
			// random nummer tussen 1 en oneindig?
			Random r = new Random();
			return r.Next(2, 4);
		}

		static int GenereerWillekeurigGetalLimieten(int min, int max) 
		{
			Random r = new Random();
			return r.Next(min, max);
		}

		//lotto 

		static string GenereerLottoGetallen()
		{
			string[] output = new String[6];
			for (int i = 0; i < 6; i++)
			{
				int newNumber;
				do
				{
					newNumber = GenereerWillekeurigGetalLimieten(1,45);
				} while ( Array.Exists(output, element => element == newNumber.ToString()) == true);
				output[i] = newNumber.ToString();
			}
			return string.Join(" ", output);
		}

		static void LottoTrekking()
		{
			SchrijfLog("Lotto wordt getrokken");
			for (int i = 0; i < 6; i++)
			{
				SchrijfLog(GenereerWillekeurigGetalLimieten(1,45));
				rumble(1,45, 5000);
			}
		}

		static void rumble(int min, int max, int duration) 
		{	
			int rumbleTime = 100;
			int counter = duration / rumbleTime;
			for (int i = 0; i < counter; i++)
			{
				SchrijfLog(GenereerWillekeurigGetalLimieten(min, max));
				Console.SetCursorPosition(0, Console.CursorTop - 1);
				Thread.Sleep(rumbleTime);
			} 
		}

		static string genereerEuroMillions()
		{
			string[] getallen = new String[5];
			string[] sterren = new String[2];
			for (int i = 0; i < 5; i ++)
			{
				int newNumber;
				do
				{
					newNumber = GenereerWillekeurigGetalLimieten(1,50);
				} while ( Array.Exists(getallen, element => element == newNumber.ToString()) == true);

				getallen[i] = newNumber.ToString();
			}
			for (int i = 0; i < 2; i ++)
			{
				int newNumber;
				do
				{
					newNumber = GenereerWillekeurigGetalLimieten(1,12);
				} while ( Array.Exists(sterren, element => element == newNumber.ToString()) == true);
				
				sterren[i] = newNumber.ToString();
			}
			return "getallen: " + string.Join(" ", getallen) + " | sterren: " + string.Join(" ", sterren);
		}

		

		static void EuroMillion()
		{
			SchrijfLog("EuroMillions wordt getrokken");
			SchrijfLog("Getallen");
			for (int i = 0; i < 5; i++)
			{
				rumble(1,50, 2000);
				SchrijfLog(GenereerWillekeurigGetalLimieten(1,50));
			}
			SchrijfLog("Sterren");
			for (int i = 0; i < 2; i++)
			{
				rumble(1,12, 2000);
				SchrijfLog(GenereerWillekeurigGetalLimieten(1,12));
				
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
				return String.Format("De account van {0} {1} is: {2}", voornaam, familienaam, String.Format("{0}{1}@arteveldehs.be", GenereerString(voornaam.ToLower(),4), GenereerString(familienaam.ToLower(),2)));
			} else {
				return String.Format("De account van {0} {1} is: {2}", voornaam, familienaam, String.Format("{0}{1}@student.arteveldehs.be", GenereerString(voornaam.ToLower(),4), GenereerString(familienaam.ToLower(),4)));
			}
			
		}

		static string ConvertLetterToNumber(string letters)
		{
			string alphabet = "abcdefghijklmnopqrstuvwxyz";
			int index1 = alphabet.IndexOf(letters.Substring(0,1).ToLower());
			int conversion1 = index1 + 10;
			int index2 = alphabet.IndexOf(letters.Substring(1,1).ToLower());
			int conversion2 = index2 + 10;
			string conversion = conversion1.ToString() + conversion2.ToString();
			return conversion;
		}

		static bool ibanValidator(string iban)
		{
			iban = iban.Replace(" ", "");
			// check length
			if(iban.Length != 16)
			{
				return false;
			}
			// split string 
			string[] ibanArray = new String[8];
			for (var i = 0; i < 8; i += 1)
			{
				ibanArray[i] = iban.Substring(i*2, 2);
			}

			// check BE
			if(ibanArray[0] != "BE")
			{
				return false;
			}

			// move BE
			string[] ibanArrayMoved = new String[8];
			for (var i = 0; i < 6; i += 1)
			{
				ibanArrayMoved[i] = ibanArray[i+2];
			}
			ibanArrayMoved[6] = ibanArray[0];
			ibanArrayMoved[7] = ibanArray[1];

			// convert to numbers
			ibanArrayMoved[6] = ConvertLetterToNumber(ibanArrayMoved[6]);
			long ibanNumberMoved = System.Convert.ToInt64(string.Join("", ibanArrayMoved));

			// check modulo
			if(ibanNumberMoved % 97 != 1)
			{
				SchrijfLog("ee");
				return false;
			}

			return true;
		}
		
		static void Faculteit()
		{
			SchrijfLog("Faculteit van welk nummer?");
			int getal = Convert.ToInt32(Console.ReadLine());
			int teller = 1;
			int tempProduct = 1;

			while (teller <= getal) {
				tempProduct *= teller;
				teller += 1;
			}
			SchrijfLog("Faculteit van " + Convert.ToString(getal) + " is " + Convert.ToString(tempProduct));
		}

		static void Fibonacci()
		{	
			SchrijfLog("Fibonacci tot hoeveel nummers?");
			int lengteReeks = Convert.ToInt32(Console.ReadLine());
			int teller = 0;
			int oldSom = 0;	/* first number */	
			int tempSom = 1;	/* second number */
			SchrijfLog(oldSom); 
			SchrijfLog(tempSom);
			while (teller < lengteReeks)
			{
				int newSom = tempSom + oldSom;
				oldSom = tempSom;
				tempSom = newSom;
				SchrijfLog(tempSom);
				teller++;
			}
		}
    	}
}
