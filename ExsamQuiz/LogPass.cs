using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace ExsamQuiz
{
    public class LogPass
    {
        public string? login;
        public string? password;
        public static List<string> logpass = new();

        public void InFile(string str_user, string path)
        {
            using (FileStream ff = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(ff))
                {
                    sw.WriteLine(str_user);
                }
            }
            Console.WriteLine($"confirmed : {str_user}");
        }
        public bool OutFile(string str_user, string path)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string log;
                while ((log = sr.ReadLine()) != null)
                {
                    if (log == str_user)
                    {
                        Console.WriteLine($"confirmed : {str_user}");   
                        return true;
                    }
                }
            }
            return false;
        }
        public void CreateLog()
        {
            int res = 0; string log_user;
            if (!File.Exists("LOGIN.txt"))
            { File.Create("LOGIN.txt").Close(); }
            Found:
            do
            {
                Console.WriteLine("Введите логин (не менее 5 букв, цифра не может быть первой)");
                string logPattern = @"^\D([a-zA-Z0-9]+)\w{5}$";
                Console.Write("Login : ");
                log_user = Console.ReadLine();
                Regex regex = new Regex(logPattern);
                res = regex.IsMatch(log_user) ? 1 : 0;                 
                if (res == 0) Console.WriteLine("Incorrect login!");
            } while (res == 0);
            if (res == 1)
            {
                try
                {                    
                    using (StreamReader sr = new StreamReader("LOGIN.txt", Encoding.UTF8))                    
                    {
                        string log;
                        while ((log = sr.ReadLine()) != null)
                        {
                            if (log == log_user)
                            {
                                Console.WriteLine("Такой логин занят!!!");
                                goto Found;
                            }                           
                        }
                    }                 
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                login = log_user;
                InFile(log_user, "LOGIN.txt");
            }
        }        
        public void CreatePas()
        {
            int res = 0; string pas_user;
            if (!File.Exists("PASSW.txt"))
            { File.Create("PASSW.txt").Close(); }
            Found:
            do
            {
                Console.WriteLine("Введите пароль (не менее 8 букв)");
                string pasPattern = @"^([a-zA-Z0-9]+)\w{8}$";
                Console.Write("Login : ");
                pas_user = Console.ReadLine();
                Regex regex = new Regex(pasPattern);
                res = regex.IsMatch(pas_user) ? 1 : 0;
                if (res == 0) Console.WriteLine("Incorrect password!");
            } while (res == 0);
            if (res == 1)
            {
                try
                {
                    using (StreamReader sr = new StreamReader("PASSW.txt", Encoding.UTF8))
                    {
                        string log;
                        while ((log = sr.ReadLine()) != null)
                        {
                            if (log == pas_user)
                            {
                                Console.WriteLine("Такой пароль занят!!!");
                                goto Found;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                InFile(pas_user, "PASSW.txt");
            }
        }
        public bool LogIn(string value)
        {
            bool log = false;

            return log;
        }
        public bool PassIn(string value)
        {
            bool pass = false;

            return pass;
        }

    }
}
