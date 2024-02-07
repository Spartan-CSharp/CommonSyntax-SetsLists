using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
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
