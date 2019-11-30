using System;

namespace opdracht7
{
    class Program 
    {
        static void Main(string[] args)
        {
            /*
            Indien vrijblijvend:
                We laten de Loggin overerven door Persoon en overschrijven deze functie in Persoon. Op deze manier zullen Gebruiker,
                Docent en Student deze functie ook overerven.
            Indien verplicht in elke klasse:

            */
            Gebruiker gebruiker = new Gebruiker("Verassen", "José", 'M');
			gebruiker.LogOutput();
			Student student = new Student("Vertriest", "Hans", 'M');
			student.LogOutput();
			Docent docent = new Docent("Raes", "Kris", 'M');
			docent.LogOutput();
        }
    }
}
