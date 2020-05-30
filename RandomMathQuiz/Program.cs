using System;

namespace Praktikavimas
{
	class MathQuiz
	{
		public static void Main()
		{
			Random NumberGenerator = new Random();
			int GameCount = 0;
			int Score = 0;

			Console.WriteLine("WELCOME TO THE MATH QUIZ");
			Console.WriteLine();

			while (GameCount < 9)
			{
				int num1 = NumberGenerator.Next(0, 100);
				int num2 = NumberGenerator.Next(0, 100);

				Console.Write(num1 + " + " + num2 + " = ");

				int AdditionResult = Convert.ToInt32(Console.ReadLine());

				if (AdditionResult == num1 + num2) 
				{
					Console.WriteLine("Correct!");
					GameCount++;
					Score++;
				}
				else 
				{
					Console.WriteLine("Wrong!");
					GameCount++;
				}
				Console.WriteLine();

				int num3 = NumberGenerator.Next(0, 100);
				int num4 = NumberGenerator.Next(0, 100);

				Console.Write(num3 + " - " + num4 + " = ");

				int SubtractionResult = Convert.ToInt32(Console.ReadLine());

				if (SubtractionResult == num3 - num4) 
				{
					Console.WriteLine("Correct!");
					GameCount++;
					Score++;
				}
				else 
				{
					Console.WriteLine("Wrong!");
					GameCount++;
				}

				Console.WriteLine();

				int num5 = NumberGenerator.Next(1, 10);
				int num6 = NumberGenerator.Next(1, 10);

				Console.Write(num5 + " * " + num6 + " = ");

				int MultiplicationResult = Convert.ToInt32(Console.ReadLine());

				if (MultiplicationResult == num5 * num6) 
				{
					Console.WriteLine("Correct!");
					GameCount++;
					Score++;
				}
				else 
				{
					Console.WriteLine("Wrong!");
					GameCount++;
				}
				Console.WriteLine();
			}

			int boss1 = NumberGenerator.Next(0, 100);
			int boss2 = NumberGenerator.Next(0, 100);
			int boss3 = NumberGenerator.Next(0, 50);
			int boss4 = NumberGenerator.Next(1, 5);

			int BossResult = boss1 + boss2 - boss3;
			
			Console.WriteLine("FINAL BOSS!");
			Console.WriteLine();
			
			Console.Write(boss1 + " + " + boss2 + " - "  + boss3 + " ( * " + boss4 + ") = ");

			int FinalBattle = Convert.ToInt32(Console.ReadLine());

			if (FinalBattle == BossResult * boss4) 
			{
				Console.WriteLine();
				Console.WriteLine("Boss Defeated!");
				Score++;
			}
			else 
			{
				Console.WriteLine();
				Console.WriteLine("YOU DIED");
			}
			Console.WriteLine();

			Console.WriteLine("Final score: " + Score + "/10");
			Console.WriteLine();

			switch (Score)
			{
				case 10: Console.WriteLine("Perfect score"); break;
				case 9:  Console.WriteLine("Almost perfect"); break;
				case 8:  Console.WriteLine("Great job!"); break;
				case 7:  Console.WriteLine("Getting there"); break;
				case 6:  Console.WriteLine("Avarage Joe"); break;
				case 5:  Console.WriteLine("Needs improvement"); break;
				case 4:  Console.WriteLine("See me after class"); break;
				case 3:  Console.WriteLine("Disapointing"); break;
				case 2:  Console.WriteLine("Sad"); break;
				case 1:  Console.WriteLine("Are you even trying?"); break;
				case 0:  Console.WriteLine("Borderline stupid"); break;
				default: Console.WriteLine("Error"); break;
			}
			Console.ReadLine();
		}
	}
}
