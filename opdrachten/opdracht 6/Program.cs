using System;

namespace oefening7
{
	class Program
	{
		static void Main(string[] args)
		{
			Gebruiker gebruiker = new Gebruiker("Verassen", "José", 'M');
			gebruiker.LogGegevens();
			Student student = new Student("Vertriest", "Hans", 'M');
			student.LogGegevens();
			Docent docent = new Docent("Raes", "Kris", 'M');
			docent.LogGegevens();

			Console.WriteLine("NOTE: Wachtwoorden worden twee keer gegenereert (en geprint) doordat base wordt aangeroepen. Dit door de aard van de oefening.");

        	}
	}

}
