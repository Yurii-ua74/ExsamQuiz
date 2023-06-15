using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExsamQuiz
{
    public class Quiz
    {        
        public string quiz { get; set; }           
        public int ChoiceQuiz()
        {
            Found:
            Console.Clear();
            switch (Menu.MooveArrow(3))
            {
                case 1:
                    {
                        int cnt = 0;
                        string temp = "";
                    Hashtable question = new Hashtable();
                    Hashtable answers = new Hashtable();
                    Hashtable right = new Hashtable();
                    string[] quest = new string[] { "Для чого потрібен метод Гауса?", "Що таке скалярний добуток векторів?", "Скільки вимірів мають евклідові простори?" };
                    string[] answ = new string[]
                    {
                         "а) Для розвʼязання системи лінійних алгебраїчних рівнянь. \r\nb) Для розвʼязання системи нелінійних алгебраїчних рівнянь.\r\nc) Для розвʼязання лінійних алгебраїчних рівнянь.",
                         "а) Бінарна операція над векторами, результатом якої є число.\r\nb) Бінарна операція над векторами, результатом якої є множина чисел.\r\nc) Бінарна операція над векторами, результатом якої є скаляр.",
                         "а) Евклідові простори мають будь-яку скінченну кількість вимірів.\r\nb) Евклідові простори мають нескінченну кількість вимірів. \r\nc) Евклідові простори мають по 3 виміри."
                    };
                    string[] righ = new string[] { "a", "b", "a" };
                        for (int i = 0; i < 3; i++) question.Add(i, quest[i]);
                        for (int i = 0; i < 3; i++) answers.Add(i, answ[i]);
                        for (int i = 0; i < 3; i++) right.Add(i, righ[i]);
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(question[i]);
                            Console.WriteLine(answers[i]);
                            temp = Console.ReadLine();
                            if(temp == righ[i]) 
                                cnt++;                           
                        }
                        return cnt;                       
                    }
                case 2:
                    {
                        int cnt = 0;
                        string temp = "";
                        Hashtable question = new Hashtable();
                        Hashtable answers = new Hashtable();
                        Hashtable right = new Hashtable();
                        string[] quest = new string[] { "столиця Мозамбік?", "Ріга?", "Річка Полтва знаходиться?" };
                        string[] answ = new string[]
                        {
                         "а) Матубу. \r\nb) Мапуту.\r\nc) Матобо.",
                         "а) Литва.\r\nb) Естонія.\r\nc) Латвия.",
                         "а) Львів Україна.\r\nb) Старзава Польща. \r\nc) Бендери Молдова."
                        };
                        string[] righ = new string[] { "b", "c", "a" };
                        for (int i = 0; i < 3; i++) question.Add(i, quest[i]);
                        for (int i = 0; i < 3; i++) answers.Add(i, answ[i]);
                        for (int i = 0; i < 3; i++) right.Add(i, righ[i]);
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(question[i]);
                            Console.WriteLine(answers[i]);
                            temp = Console.ReadLine();
                            if (temp == righ[i])
                                cnt++;
                        }
                        return cnt;
                    }
                case 3:
                    {
                        Console.WriteLine("ин яз");
                        Console.ReadKey(true);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("животные");
                        Console.ReadKey(true);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("смешанные");
                        Console.ReadKey(true);
                        break;
                    }
            }
            Console.WriteLine();
            goto Found;
        }
    }
}
