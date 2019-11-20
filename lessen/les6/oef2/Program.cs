using System;
using System.Threading;

namespace oefening
{	
	class Program
	{
		static void Main(string[] args)
		{	
			
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

		// implement try/catch
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
				return false;
			}

			return true;
		}
    	}
}
