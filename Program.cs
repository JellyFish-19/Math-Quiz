using System;

namespace Pajehali
{
	class TestingZone
	{
		public static void Main()
		{
			Start:
			Random NumberGenerator = new Random ();

			int num1 = NumberGenerator.Next(0, 100);
			int num2 = NumberGenerator.Next(0, 100);

			Console.Write(num1 + " + " + num2 + " = ");

			int AdditionResult = Convert.ToInt32(Console.ReadLine());

			if (AdditionResult == num1 + num2) {
				Console.WriteLine("Correct");
			}
			else {
				Console.WriteLine("Wrong");
			}
			Console.WriteLine();

		} 
    }
}
