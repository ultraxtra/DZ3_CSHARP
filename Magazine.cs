using System;
using static System.Console;

namespace DZ_SHARP3
{
	public struct Magazine
	{
		public string name;
		public string year;
		public string phone;
		public string email;

		public Magazine()
        {
			name = "Yeralash";
			year = "02.02.1986";
			phone = "+6666666666";
			email = "zxcursed228@dota.com";
        }

        public Magazine(string name, string year, string phone, string email)
        {
			this.name = name;
			this.year = year;
			this.phone = phone;
			this.email = email;

        }

		public void PrintInfo()
        {
			WriteLine($"Name:{name}\n Year:{year}\n Phone:{phone}\n Email:{email}\n");
        }

		public void FillInfo()
        {
			WriteLine("Write info:");
			this.name = EnterString("Enter name:");
			this.year = EnterString("Enter year:");
			this.phone = EnterString("Enter phone:");
			this.email = EnterString("Enter email:");
        }

        public static string EnterString(string prompt)
        {
            Console.Write($"\t{prompt}: ");
            string str = Console.ReadLine();
            str = str.Trim();//Видалення пробілів зпочатку та кінця
            return str;
        }

    }

	

    

	
}

