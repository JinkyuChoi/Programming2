using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool onOff = true;
            while (onOff == true)
            {
                Console.Write("Enter question number : ");
                int qNum = Convert.ToInt32(Console.ReadLine());
                switch (qNum)
                {
                    case 0:
                        onOff = false;
                        break;

                    case 1:
                        RequestUserName();
                        break;

                    case 2:
                        RequestUserAge();
                        break;

                    case 3:
                        DisplayPersonalInfo(RequestUserName(), RequestUserAge());
                        break;

                    case 4:
                        Console.Write("Enter any word : ");
                        string word = Console.ReadLine();
                        Console.WriteLine(StartsWithVowel(word));
                        break;

                    case 5:
                        Console.Write("Enter any number : ");
                        int astNum = Convert.ToInt32(Console.ReadLine());
                        AsteriskPrinter(astNum);
                        break;

                    case 6:
                        Console.Write("Enter any number for width : ");
                        int width = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter any number for height : ");
                        int height = Convert.ToInt32(Console.ReadLine());
                        BoxDrawer(width, height);
                        break;

                    case 7:
                        Console.Write("Enter any number for width : ");
                        int width2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter any number for height : ");
                        int height2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(BoxMaker(width2, height2));
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static string RequestUserName()
        {
            Console.Write("Enter your name : ");
            return Console.ReadLine();
        }

        public static int RequestUserAge()
        {
            Console.Write("Enter your age : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void DisplayPersonalInfo(string name, int age)
        {
            Console.WriteLine("Name : {0}\nAge : {1}", name, age);
        }

        public static bool StartsWithVowel(string word)
        { 
            char[] wordSpell = word.ToLower().ToCharArray();
            if (wordSpell[0] == 'a' || wordSpell[0] == 'e' || wordSpell[0] == 'i' || wordSpell[0] == 'o' || wordSpell[0] == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AsteriskPrinter(int astNum)
        {
            for(int i = 0; i < astNum; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        public static void BoxDrawer(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for(int i = 0; i < height - 2; i++)
            {
                Console.Write("*");
                for(int j = 0; j < width - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (int i = 0; i < width; i++)
            {
                Console.Write("*");
            }
        }

        public static string BoxMaker(int width, int height)
        {
            char[] boxRow = new char[width +1];
            string[] boxColumn = new string[height];
            for (int rowCounter = 0; rowCounter < height; rowCounter++)
            {
                if (rowCounter == 0 || rowCounter == height - 1)
                {
                    for (int i = 0; i < width; i++)
                    {
                        boxRow[i] = '*';
                    }
                    boxRow[width] = '\n';
                }
                else
                {
                    boxRow[0] = '*';
                    for(int i = 1; i < width-1; i++)
                    {
                        boxRow[i] = ' ';
                    }
                    boxRow[width - 1] = '*';
                    boxRow[width] = '\n';
                }
                boxColumn[rowCounter] = new string(boxRow);
            }
            string box = string.Join("",boxColumn);
            return box;
        }
    }
}
