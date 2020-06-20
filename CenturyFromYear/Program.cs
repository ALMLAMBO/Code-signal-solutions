using System;

namespace CenturyFromYear {
	class Program {
		static void Main(string[] args) {
			int year = int.Parse(Console.ReadLine());

			string firstTwoDigits = year.ToString().Substring(0, 2);
			int onlyFirstTwoDigits = int.Parse(firstTwoDigits);
			Console.WriteLine(onlyFirstTwoDigits + 1);
		}
	}
}
