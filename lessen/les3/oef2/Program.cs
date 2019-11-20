using System;

namespace oef2
{
    class Program
    {
        static void Main(string[] args)
        {
		/*
		OEF A
		for (int i = 0; i < 10; i ++)
		{
			Console.WriteLine(Convert.ToString(i) + " x 5 = " + Convert.ToString(i*5));
		}

		OEF B
		for (int getal = 1; getal < 10; getal++)
		{
			for (int tafel = 0; tafel <= 10; tafel ++)
			{
			Console.WriteLine(Convert.ToString(getal) + " x "+Convert.ToString(tafel)+" = " + Convert.ToString(tafel*getal));
			}
		}
		OEF B
		*/
		int getal;
		getal = Convert.ToInt32(Console.ReadLine());
			for (int tafel = 1; tafel <= 10; tafel ++)
			{
				Console.WriteLine(Convert.ToString(getal) + " x "+ Convert.ToString(tafel)+" = " + Convert.ToString(tafel*getal));
			}
		
        }
    }
}
