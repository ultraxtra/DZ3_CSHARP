using System;
using static System.Console;
namespace DZ_SHARP3
{
	public struct Shop
	{
		public string name;
		public string ip;
		public string web;
		public string description;

		public Shop()
        {
			name = "Adidas";
			ip = "228.1337.02.25";
			web = "https://www.adidas.cz";
			description = "Shop";
        }

		public Shop(string name, string ip, string web, string description)
        {
			this.name = name;
			this.ip = ip;
			this.web = web;
			this.description = description;
        }

		public void PrintInfo()
        {
			WriteLine($"Name of the shop:{name}\n Shop ip: {ip}\n Shop website:{web}\n Description:{description}");
        }

        public void FillInfo()
        {
            Console.WriteLine("Info adding:");
            this.name = EnterString("Enter name of the page");
            this.ip = EnterString("Enter IP");
            this.web = EnterString("Enter URL");
            this.description = EnterString("Enter description");

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

