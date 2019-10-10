using System;

namespace oef3
{
    class Program
    {
        static void Main(string[] args)
        {
		/*
		Oef A
		int limit = 10;
		int tafel = 1;
		while (tafel <= limit)
		{
			Console.WriteLine(Convert.ToString(tafel) + " x 5 = " + Convert.ToString(tafel*5));
			tafel++;
		}
		Oef B
		
		int limit = 10;
		int tafel = 1;
		
		while (tafel <= limit)
		{
			int getal = 1;
			while (getal <= limit) 
			{
				Console.WriteLine(Convert.ToString(getal) + " x  "+Convert.ToString(tafel)+" = " + Convert.ToString(tafel*getal));
				getal++;
			}
			tafel++;
		}
		Oef C
		*/
		int getal;
		getal = Convert.ToInt32(Console.ReadLine());
		int limit;
		limit = 10;
		int tafel;
		tafel = 1;
		while (tafel <= limit)
		{
			Console.WriteLine(Convert.ToString(tafel) + " x "+Convert.ToString(getal)+" = " + Convert.ToString(tafel*getal));
			tafel++;
		}

        }
    }
}
