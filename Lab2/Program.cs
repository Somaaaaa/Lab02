using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. feladat
            /*
            Console.Write("Adj meg egy számot: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
            */
            #endregion
            #region 2. feladat
            /*
            string password = "alma";
            Console.Write("Add meg a helyes a jelszót: ");
            string answer = Console.ReadLine();
            int countWrongAttempts = 1;
            while (password != answer)
            {
                countWrongAttempts++;
                Console.Write("Add meg a helyes a jelszót: ");
                answer = Console.ReadLine();
                if(countWrongAttempts == 3) {
                    Console.WriteLine("Háromszor elrontottad");
                    countWrongAttempts = 0;
                }
            }
            */
            #endregion
            #region 3. feladat
            /*
            Console.Write("Próbáld meg kitalálni melyik számra gondoltam 1 és 1000 között: ");
            int answer = int.Parse(Console.ReadLine());
            int attempts = 0;
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 1000);
            while (answer != randomNumber && attempts < 3)
            {
                attempts++;
                Console.Write("Helytelen. Próbáld újra ");
                answer = int.Parse(Console.ReadLine());             
            }
            Console.WriteLine("A helyes szám " + answer +" volt és ennyi próbálkozás kellett: " + attempts);
            */
            #endregion
            #region 4. feladat
            /*
            Console.Write("Hány játékos van? ");
            int countPlayers = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int currentThrow = 0;
            do
            {
                int i = 1;
                while (i <= countPlayers && currentThrow != 6)
                {
                    currentThrow = rnd.Next(1, 7);
                    Console.WriteLine(i + " " + currentThrow);
                    if (currentThrow == 6)
                    {
                        Console.WriteLine(i + ". játékos kezd");
                    }
                    i++;
                  }
            } while (currentThrow != 6);
            */
            #endregion
            #region 5. feladat
            /*
            Random rnd = new Random();
            int number = rnd.Next(1, 1001);
            int answer = 1;
            int attempts = 0;
            Console.WriteLine(number);
            do
            {
                Console.Write("gondoltam egy számra 1 és 100, találd ki: ");
                answer = int.Parse(Console.ReadLine());
                if(answer < number)
                {
                    Console.WriteLine("A szám nagyobb");
                    attempts++;
                }
                else
                {
                    if(answer == number)
                    {
                        attempts++;
                        Console.WriteLine("Eltaláltad, a helyes szám: " + number + " volt és enni probálkozás: " +  attempts);
                    }
                    else
                    {
                        Console.WriteLine("A szám kisebb");
                        attempts++;
                    }            
                }
            } while (answer != number);
            */
            #endregion
            #region 6. feladat 
            /*
            Console.Write("Adj meg egy számot ");
            int number = int.Parse(Console.ReadLine());
            int dividers = 0;
            if (number % 2 == 0)
            {
                Console.WriteLine("a szám páros");
            }
            else
            {
                Console.WriteLine("a szám páratlan");
            }
            for(int i = 2; i< number; i++)
            {
                if(number%i == 0)
                {
                    dividers++;
                }
            }
            Console.WriteLine("osztók száma: "+dividers);
            if (dividers == 0)
            {
                Console.WriteLine("A szám prím");
            }
            else
            {
                Console.WriteLine("A szám nem prím");
            }
            */
            #endregion
            #region 7. feladat
            /*
            Console.Write("Adj meg egy számot és kiszámolom a faktoriálisát :");
            int number = int.Parse(Console.ReadLine());
            int answer = number;
            for(int i = number-1; i>=1; i--)
            {
                answer = answer * i;
            }
            Console.WriteLine(number +"! = "+answer);
            */
            #endregion
            #region 8. feladat
            /*
            for(int i = 1; i<=9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.Write(i*j+" ");
                }
                Console.WriteLine();
            }
            */
            #endregion
            #region 9. feladat
            /*
            Console.Write("Ajd meg egy intervallumot másodpercben: ");
            int time = int.Parse(Console.ReadLine());
            do
            {
                Console.Clear();
                Console.WriteLine(time/60 + ":" + time%60);
                time--;
                System.Threading.Thread.Sleep(1000);
            } while (time != 0);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            */
            #endregion
            #region 10. feladat
            /*
            Console.Write("Adj meg egy 10-es számrendszer beli szémot amit átváltok 2-es számrendszerbe ");          
            uint answer = uint.Parse(Console.ReadLine());
            string result = string.Empty;
            int count = 0;
            Console.Write(answer + " (10) = ");
            while (answer != 0)
            {
                if(count%8 == 0 && count != 0)
                {
                    result = " " + result;
                }
                result = (answer % 2).ToString() + result;
                answer /= 2;
                count++;
            }
            int space = 0;
            for (int i = 0; i < 32 - count; i++)
            {
                Console.Write("0");
                space++;
                if(space == 8)
                {
                    Console.Write(" ");
                    space = 0;
                }
            }
            Console.Write("{0} (2)", result);
            */
            #endregion
            #region 11. feladat
            /*
            Random rnd = new Random();
            int kredit = 100;
            int currentBet = 1;      
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            Console.WriteLine("kredit: " + kredit);
            Console.WriteLine("currentBet: " + currentBet);
            var input = Console.ReadKey().Key;
            do
            { 
                while (input != ConsoleKey.Spacebar)
                {                 
                    if (input == ConsoleKey.UpArrow)
                    {
                        currentBet++;
                        Console.Clear();
                        Console.WriteLine("kredit: " + kredit);
                        Console.WriteLine("currentBet " + currentBet);
                    }
                    if (input == ConsoleKey.DownArrow)
                    {
                        currentBet--;
                        Console.Clear();
                        Console.WriteLine("kredit: " + kredit);
                        Console.WriteLine("currentBet " + currentBet);
                    }
                    input = Console.ReadKey().Key;
                }
                number1 = rnd.Next(1, 101);
                number2 = rnd.Next(1, 101);
                number3 = rnd.Next(1, 101);
                if (number1 == number2 || number2 == number3 || number1 == number3)
                {
                    if (number1 == number2 && number1 == number3)
                    {
                        kredit += currentBet * 50;
                        Console.Clear();
                        Console.WriteLine("NYEREMÉNY: " + currentBet * 10);
                    }
                    else
                    {
                        kredit += currentBet * 10;
                        Console.Clear();
                        Console.WriteLine("NYEREMÉNY: " + currentBet * 10);     
                    }             
                }
                Console.WriteLine(number1+" " +number2+" "+number3);
                kredit -= currentBet;
                currentBet = 1;
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("kredit: " + kredit);
                Console.WriteLine("currentBet: " + currentBet);
                input = Console.ReadKey().Key;
            } while (kredit > 0 && input != ConsoleKey.Escape);
            */
            #endregion
            #region 12. feladat

            #endregion
            Console.ReadKey();
        }
    }
}
