using System;

namespace oef4
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = Convert.ToInt32(Console.ReadLine());
		int teller = 1;
		int tempProduct = 1;

		while (teller <= getal) {
			tempProduct *= teller;
			teller += 1;
		}
		Console.WriteLine("Faculteit van " + Convert.ToString(getal) + " is " + Convert.ToString(tempProduct));

        }
    }
}
