using System.Collections;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace ExsamQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            QuizParticipant participant = new QuizParticipant();
            Quiz quizz = new Quiz();
            ArrayList teem = new ArrayList();
            teem.Add("Bohdan");
            teem.Add("Anna");
            teem.Add("Olga");
            teem.Add("Yanis");
            Random rnd = new Random();
            ArrayList rati = new ArrayList();
            for(int i = 0; i < 4; i++)
                rati.Add(rnd.Next(1, 9));           
            Hashtable rating = new Hashtable();
            for(int i = 0; i < 4; i++)
                rating.Add(teem[i], rati[i]);
            Found:
            Console.Clear();
            switch (Menu.MooveArrow(1))
            {
                case 1:
                    {
                        Console.Clear();
                        LogPass lp = new();
                        lp.CreateLog();                       
                        lp.CreatePas();                      
                        Console.WriteLine("Регистрация завершена!");
                        Console.ReadKey(true);
                        goto Found;
                        //break;
                    }
                case 2:
                    {
                        Found1:
                        int rt = 0;
                        Console.Clear();
                        Console.WriteLine("Введите логин : ");
                        LogPass lp = new();
                        bool log = lp.OutFile(Console.ReadLine(), "LOGIN.txt");
                        Console.WriteLine("Введите пароль : ");
                        bool pas = lp.OutFile(Console.ReadLine(), "PASSW.txt");
                        Console.Clear();
                        if (log == true && pas == true)                       
                        {
                            Console.SetCursorPosition(45, 10);
                            Console.ForegroundColor = (System.ConsoleColor)ConsoleColor.Green;
                            Console.WriteLine("Успешный вход!");
                            Console.ResetColor();
                            Console.SetCursorPosition(40, 11);
                            Console.Write("Введите свое имя : ");
                            string partic = Console.ReadLine();
                            participant.Participant = partic;
                            Console.Clear();
                            Console.SetCursorPosition(45, 10);
                            teem.Add(partic);
                            rating.Add(partic, rt);
                            Console.WriteLine($"Привет {participant.Participant}!");
                            Console.ReadKey(true);
                            Console.Clear();
                            Found11:
                            int ratt = quizz.ChoiceQuiz();                           
                            participant.Rating += ratt;
                            rating[partic] = participant.Rating;
                            Console.WriteLine("Продолжить викторину? \"Y\"  \"N\"");
                            char ch = char.Parse(Console.ReadLine());
                            if(ch == 'Y' || ch == 'y' || ch == 'Н' || ch == 'н') goto Found11;
                            Console.WriteLine("     Рейтинг");
                            participant.RatTable(teem, rating);
                        }else 
                        {
                            Console.SetCursorPosition(45, 10); 
                            Console.WriteLine("Неверный логин или пароль!");
                            Console.ReadKey(true);
                            goto Found1; 
                        }
                        Console.ReadKey(true);
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("XXX");
                        break;
                    }
            }
        }
    }
}