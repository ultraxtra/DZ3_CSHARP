using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace DZ_SHARP3
{
	public class Palindrom
	{
		long a;
		public Palindrom() { }
		public Palindrom(int number)
		{ a = number; }

        public void Print()
        {
            Console.WriteLine("number={0}", a);
        }

        public bool IsPalindrom()
        {
            List<int> digits = new List<int>(20);
            long num = a;

            if (num < 0)
                num = -num;

            while (num > 0)
            {
                digits.Add((int)(num % 10));
                num /= 10;
            }
            for (int i = 0; i < digits.Count / 2; i++)
                if (digits[i] != digits[digits.Count - 1 - i])
                    return false;

            return true;
        }

        

	}
}

