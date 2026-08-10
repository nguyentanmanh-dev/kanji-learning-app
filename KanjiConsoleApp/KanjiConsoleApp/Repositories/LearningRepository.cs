using System;
using System.Collections.Generic;
using System.Text;
using KanjiConsoleApp.Models;
using KanjiConsoleApp.Interfaces;

namespace KanjiConsoleApp.Repositories
{
    public class LearningRepository : ILearningRepository
    {
        private readonly List<LearningItem> _items = new();
        public void Add(LearningItem item)
        {
            _items.Add(item);
        }
        public List<LearningItem> GetAll()
        {
            return _items;
        }
        public List<LearningItem> Search(string keyword)
        {
            return _items.Where(i => 
            (i is Kanji k && (k.Character.Contains(keyword) || k.Meaning.Contains(keyword))) || (i is Vocabulary v && (v.Word.Contains(keyword) || v.Meaning.Contains(keyword)))
            ).ToList();
        }
        public List<LearningItem> Remove(string id)
        {
            var itemToRemove = _items.FirstOrDefault(i => i.Id == id);
            if (itemToRemove != null)
            {
                _items.Remove(itemToRemove);
            }
            return _items;
        }
    }
}
