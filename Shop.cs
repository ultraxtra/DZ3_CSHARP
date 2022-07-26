using System;
using static System.Console;
namespace DZ_SHARP3
{
	public struct Shopp
	{
		public string name;
		public string adres;
		public string description;
		public string phone;
		public string email;

		public Shopp(){
			name = "Ryaba";
			adres = "Gogolya 69";
			description = "The best kurochka";
			phone = "2281337";
			email = "kurkaryaba228@gmail.com";
		}

		public Shopp(string name, string adres, string description, string phone, string email)
        {
			this.name = name;
			this.adres = adres;
			this.description = description;
			this.phone = phone;
			this.email = email;
        }

		public void PrintInfo()
        {
			WriteLine($"Name:{name}\n Adres:{adres}\n Description:{description}, Phone:{phone}, Email:{email}");
        }

        public void FillInfo()
        {
            Console.WriteLine("Info adding:");
            this.name = EnterString("Enter name of the shop");
            this.adres = EnterString("Enter adres");
            this.description = EnterString("Enter description");
            this.phone = EnterString("Enter phone");
            this.email = EnterString("Enter email");

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

