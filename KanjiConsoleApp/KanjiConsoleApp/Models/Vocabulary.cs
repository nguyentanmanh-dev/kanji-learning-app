using System;
using System.Collections.Generic;
using System.Text;
using KanjiConsoleApp.Interfaces;

namespace KanjiConsoleApp.Models
{   
    public class Vocabulary : LearningItem, IStudyable
    {
        public string Word;
        public string Meaning;
        public Vocabulary(string word, string meaning)
        {
            Word = word;
            Meaning = meaning;
        }
        public override void Display()
        {
            Console.WriteLine($"[Từ vựng] {Word} - Nghĩa: {Meaning} | Created: {CreatedAt:dd/MM/yyyy}");
        }
        public void review()
        {
            Console.WriteLine($"Reviewing Vocabulary: {Word}");
        }
    }
}
