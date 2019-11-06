using System;

namespace Program
{
	class Calculator{

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
			var calculator =  new Calculator(8,3);
			Console.WriteLine(calculator.multiply());
			Console.WriteLine(calculator.add());
			Console.WriteLine(calculator.divide());
			Console.WriteLine(calculator.subtract());

		}
	}
}
