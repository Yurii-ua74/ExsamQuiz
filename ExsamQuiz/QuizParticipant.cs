using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExsamQuiz
{
    public class QuizParticipant
    {
        private string? participant { get; set; }
        private int rating { get; set; }
        public string Participant
        {
            get { return participant; }
            set { participant = value; }
        }
        public int Rating
        { 
            get { return rating; }
            set { rating = value; }
        }              
        public void RatTable(ArrayList teem, Hashtable rating)
        {
            foreach (DictionaryEntry rt in rating)
            {
                Console.WriteLine($"Name = {rt.Key} \t Points = {rt.Value}");
            }
        }
    }
}
