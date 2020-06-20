using System;

namespace CenturyFromYear {
	class Program {
		static void Main(string[] args) {
			int year = int.Parse(Console.ReadLine());

			if(year % 100 == 0) {
				Console.WriteLine(year / 100);
				return;
			}

			if(year.ToString().Length <= 2) {
				Console.WriteLine(1);
				return;
			}

			string firstTwoDigits = year.ToString().Substring(0, 2);
			int onlyFirstTwoDigits = int.Parse(firstTwoDigits);
			Console.WriteLine(onlyFirstTwoDigits + 1);
		}
	}
}
