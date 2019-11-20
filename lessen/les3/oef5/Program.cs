using System;

namespace oef5
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengteReeks = Convert.ToInt32(Console.ReadLine());
		int teller = 0;
		int oldSom = 0;	
		int tempSom = 1;

		while (teller < lengteReeks)
		{
			int newSom = tempSom + oldSom;
			oldSom = tempSom;
			tempSom = newSom;
			Console.WriteLine(tempSom);
			teller++;
		}
        }
    }
}
