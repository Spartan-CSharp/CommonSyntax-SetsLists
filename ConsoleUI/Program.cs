using System;
using System.Collections.Generic;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			List<string> studentnames = new List<string>();
			int studentcount = 0;
			string morestudents;

			do
			{
				Console.Write("Enter Student Name: ");
				studentnames.Add(Console.ReadLine());
				studentcount++;
				Console.Write("More Students (yes/no): ");
				morestudents = Console.ReadLine();
			} while ( morestudents == "yes" );

			Console.WriteLine($"You entered {studentcount} students.");

			_ = Console.ReadLine();
		}
	}
}
