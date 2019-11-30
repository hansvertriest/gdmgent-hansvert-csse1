using System;
using System.Threading;

namespace opdracht7
{
    class Functies 
    {
		static void LogOutput(string output) => Console.WriteLine(output);

		static void LogOutput(double output) => Console.WriteLine(output.ToString());

        static double multiply(double Getal1, double Getal2)
		{
			return Getal1 * Getal2;
		}

		static double add(double Getal1, double Getal2)
		{
			return Getal1 + Getal2;
		}

		static double subtract(double Getal1, double Getal2)
		{
			return Getal1 - Getal2;
		}

		static double divide(double Getal1, double Getal2)
		{
			return Getal1 / Getal2;
		}

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

		public static void LottoTrekking()
		{
			LogOutput("Lotto wordt getrokken");
			for (int i = 0; i < 6; i++)
			{
				LogOutput(GenereerWillekeurigGetal(1,45));
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
				LogOutput(GenereerWillekeurigGetal(min, max));
				Console.SetCursorPosition(0, Console.CursorTop - 1);
				Thread.Sleep(200);
			} 
		}

		static void EuroMillion()
		{
			LogOutput("EuroMillions wordt getrokken");
			LogOutput("Getallen");
			for (int i = 0; i < 5; i++)
			{
				rumble(1,50);
				LogOutput(GenereerWillekeurigGetal(1,50));
			}
			LogOutput("Sterren");
			for (int i = 0; i < 2; i++)
			{
				rumble(1,9);
				LogOutput(GenereerWillekeurigGetal(1,9));
				
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
				LogOutput("ee");
				return false;
			}

			return true;
		}
		
		static void Faculteit()
		{
			LogOutput("Faculteit van welk nummer?");
			int getal = Convert.ToInt32(Console.ReadLine());
			int teller = 1;
			int tempProduct = 1;

			while (teller <= getal) {
				tempProduct *= teller;
				teller += 1;
			}
			LogOutput("Faculteit van " + Convert.ToString(getal) + " is " + Convert.ToString(tempProduct));
		}

		static void Fibonacci()
		{	
			LogOutput("Fibonacci tot hoeveel nummers?");
			int lengteReeks = Convert.ToInt32(Console.ReadLine());
			int teller = 0;
			int oldSom = 0;	/* first number */	
			int tempSom = 1;	/* second number */
			LogOutput(oldSom); 
			LogOutput(tempSom);
			while (teller < lengteReeks)
			{
				int newSom = tempSom + oldSom;
				oldSom = tempSom;
				tempSom = newSom;
				LogOutput(tempSom);
				teller++;
			}
		}
    }
}