using System;
using System.Collections.Generic;
using System.Text;
using KanjiConsoleApp.Interfaces;

namespace KanjiConsoleApp.Models
{
    public class Kanji : LearningItem, IStudyable
    {
        private string _character;
        public string Character
        {
            get => _character;
            set => _character = string.IsNullOrEmpty(value) ? throw new ArgumentException("Kanji character cannot be null or empty.") : value;
        }
        public string OnYomi { get; set; }
        public string KunYomi { get; set; }
        public string Meaning { get; set; }
        public int StrokeCount { get; set; }
        public string JlptLevel { get; set; }
        public Kanji(string character, string onYomi, string kunYomi, string meaning, int strokeCount, string jlptLevel )
        {
            Character = character;
            OnYomi = onYomi;
            KunYomi = kunYomi;
            Meaning = meaning;
            StrokeCount = strokeCount;
            JlptLevel = jlptLevel;
        }
        public override void Display()
        {
            Console.WriteLine($"[{Id}] {Character} - On: {OnYomi}, Kun: {KunYomi}, Meaning: {Meaning}, Stroke Count: {StrokeCount}, JLPT Level: {JlptLevel}");
        }
        public void review()
        {
            Console.WriteLine($"Reviewing Kanji: {Character}");
        }
    }
}
