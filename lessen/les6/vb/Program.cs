using System;

namespace les6
{
    class Program
    {
        static void Main(string[] args)
        {	
		//unhandled exception -> exception that's not been caught
		object o = null;
		try
		{
			int i = (int)o;
		}
		catch(NullReferenceException e)
		{
			Console.WriteLine("NRE: " + e.Message);
		}
		catch(InvalidCastException e)
		{
			Console.WriteLine("ICE" + e.Message);
		}
		//   Algemene exception mag niet vanboven staan, want onderste meer specifieke catch wordt niet utigevoerd => NO BUILD
		  catch(Exception e)
		  {
			  Console.WriteLine("NRE: " + e.Message);
		  }
		// executes after catch. No exception thrown = no finally run
		finally 
		{
			Console.WriteLine("Finally");
		}
        }
    }
}
