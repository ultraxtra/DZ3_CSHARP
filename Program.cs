using static System.Console;
using System;

namespace DZ_SHARP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program1();
            //Program2();
            //Program3();
            Program4();
            //Program5();
            //Program6();
            ReadKey(true);
        }

        static void PrintSquare(int length, int width, string symbol)
        {
            for(int i = 0; i < length; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if ((i >= 1 && i <= length - 2) && (j >= 1 && j <= width - 2))
                    {
                        Console.Write(" ");
                    }
                    else
                    {

                        Console.Write(symbol);
                    }
                }
                Console.Write("\n\n");
            
            }
        }

        static void Array(int[] arr,int size, int i)
        {
            while (i < size)
            {
                arr[i] = int.Parse(ReadLine());
                i++;
            }
            for(i = 0; i <size; i++)
            {
                Write($"{arr[i]}\t");

            }
    
        }

        static void RmvArray(int[] rmvarr, int sizeofrmvarr, int j)
        {
            while (j < sizeofrmvarr)
            {
                rmvarr[j] = int.Parse(ReadLine());
                j++;
            }
            for (j = 0; j < sizeofrmvarr; j++)
            {
                Write($"{rmvarr[j]}\t");

            }
        }



        static void Program1()
        {
            WriteLine("Enter length:");
            int length = Convert.ToInt32(ReadLine());
            WriteLine("Enter width:");
            int width = Convert.ToInt32(ReadLine());
            WriteLine("Enter symbol:");
            string symbol = ReadLine();
            PrintSquare(length, width, symbol);
        }

        static void Program2()
        {
            int number;
            try
            {
                WriteLine("Enter number:");
                number = Convert.ToInt32(ReadLine());
                Palindrom t = new Palindrom(number);
                t.Print();
                if (t.IsPalindrom())
                {

                    WriteLine("Number is palindrom");
                }
                else
                {
                    WriteLine("Number is not a palindrom");
                }
            }
            catch
            {
                Write("Error!");
            }
        }

        static void Program3()
        {
            int size;
            int i = 0;
            WriteLine("Enter size of array:");
            size = Convert.ToInt32(ReadLine());

            int[] arr = new int[size];
            WriteLine("Enter array:");

            Array(arr, size, i);

            WriteLine();

            int sizeofrmvarr;
            int j = 0;
            WriteLine("Enter the size of rmvarr:");
            sizeofrmvarr = Convert.ToInt32(ReadLine());

            int[] rmvarr = new int[sizeofrmvarr];
            WriteLine("Enter array:");


            RmvArray(rmvarr, sizeofrmvarr, j);
            WriteLine();

            int sizze = size - sizeofrmvarr;
            int[] array = new int[sizze];
            int b;

            IEnumerable<int> onlyInFirstSet = arr.Except(rmvarr);

            foreach (int number in onlyInFirstSet)
                Console.Write(number);
        }

        static void Program4()
        {
            Shop shp = new Shop();
            Shop shp1 = new Shop();

            shp.PrintInfo();
            shp1.FillInfo();
            shp1.PrintInfo();
        }

        static void Program5()
        {
            Magazine mgz = new Magazine();
            Magazine mgz1 = new Magazine();

            mgz.PrintInfo();
            mgz1.FillInfo();
            mgz1.PrintInfo();
        }

        static void Program6()
        {
            Shopp shopp = new Shopp();
            Shopp shopp1 = new Shopp();

            shopp.PrintInfo();
            shopp1.FillInfo();
            shopp1.PrintInfo();
        }

    }
}