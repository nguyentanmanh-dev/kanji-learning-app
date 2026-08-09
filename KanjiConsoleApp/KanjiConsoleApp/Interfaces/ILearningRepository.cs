using System;
using System.Collections.Generic;
using System.Text;
using KanjiConsoleApp.Models;

namespace KanjiConsoleApp.Interfaces
{
    public interface ILearningRepository
    {
        void Add(LearningItem item);
        List<LearningItem> GetAll();
        List<LearningItem> Search(string keyword);
    }
}
