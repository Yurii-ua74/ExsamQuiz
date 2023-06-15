using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExsamQuiz
{
    public class Menu
    {
        public static readonly string[] qumenu = new string[] { "математика", "география", "ин яз", "животные", "смешанные" };
        public static readonly string[] grafic = new string[] { "═", "║", "╔", "╗", "╚", "╝" };
        public static int MooveArrow(int x)
        {
            Console.Clear();
            int min = 0, max = 0;
            if (x == 1) { min = 1; max = 3; }
            if (x == 2) { min = 1; max = 7; }
            if (x == 3) { min = 1; max = 5; }
            int k = 0;
            ConsoleKeyInfo ck;
            do
            {
                MainMenu(k, x, max);
                ck = Console.ReadKey();
                switch (ck.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (k < max) k++;
                        Console.Clear();
                        break;
                    case ConsoleKey.LeftArrow:
                        if (k > min) k--;
                        Console.Clear();
                        break;
                    case ConsoleKey.Enter:
                        {
                            Console.Clear();
                            return k;
                        }
                }
                MainMenu(k, x, max);                
            } while (k != -1);
            Console.Clear();
            return k;
        }
        public static void MainMenu(int k, int x, int max)
        {
            Console.SetCursorPosition(47, 25);
            Console.ForegroundColor = (System.ConsoleColor)ConsoleColor.Green;
            Console.WriteLine("Управление <-  ◄ ►  -> Enter ");            
            Console.ResetColor();
            if(x == 1) Print(k, x);  
            if(x == 3) PrintQuiz(k, x);
        }
        public static void Print(int k, int x)
        {
            for (int j = 15; j <= 75; j += 30)
            {
                Console.SetCursorPosition(j, 12);
                Console.Write(grafic[2]);
                for (int i = 0; i < 24; i++)
                    Console.Write(grafic[0]);
                Console.Write(grafic[3]);

                Console.SetCursorPosition(j, 13);
                Console.Write(grafic[1]);
                for (int i = 0; i < 24; i++)
                    Console.Write(" ");
                Console.Write(grafic[1]);

                Console.SetCursorPosition(j, 14);
                Console.Write(grafic[4]);
                for (int i = 0; i < 24; i++)
                    Console.Write(grafic[0]);
                Console.Write(grafic[5]);
            }
            if (k == 1)
                Console.BackgroundColor = (System.ConsoleColor)ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(19, 13);
            Console.Write("ЗАРЕГИСТРИРОВАТЬСЯ");
            Console.ResetColor();

            if (k == 2)
                Console.BackgroundColor = (System.ConsoleColor)ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(56, 13);
            Console.Write("ВОЙТИ");
            Console.ResetColor();

            if (k == 3)
                Console.BackgroundColor = (System.ConsoleColor)ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(77, 13);
            Console.Write("СОЗДАТЬ||РЕДАКТИРОВАТЬ");
            Console.ResetColor();

            for (int i = 15; i < 52; i+=2)
            {
                Console.SetCursorPosition(i, 10);
                Console.WriteLine("  ВИКТОРИНА!!!  ");               
                System.Threading.Thread.Sleep(50);
            }
        }
        public static void PrintQuiz(int k, int x)
        {
            //Console.SetCursorPosition(10, 12);
            //foreach(string st in qumenu)
            //    Console.Write(st + "   ");

            if (k == 1)
                Console.BackgroundColor = (System.ConsoleColor)ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(35, 13);
            Console.Write(qumenu[0]);
            Console.ResetColor();

            if (k == 2)
                Console.BackgroundColor = (System.ConsoleColor)ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(47, 13);
            Console.Write(qumenu[1]);
            Console.ResetColor();

            if (k == 3)
                Console.BackgroundColor = (System.ConsoleColor)ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(58, 13);
            Console.Write(qumenu[2]);
            Console.ResetColor();

            if (k == 4)
                Console.BackgroundColor = (System.ConsoleColor)ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(65, 13);
            Console.Write(qumenu[3]);
            Console.ResetColor();

            if (k == 5)
                Console.BackgroundColor = (System.ConsoleColor)ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(75, 13);
            Console.Write(qumenu[4]);
            Console.ResetColor();
        }

    }
}
