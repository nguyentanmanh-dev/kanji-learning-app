using KanjiConsoleApp.Models;
using System.Text;
using System.Linq;

Console.OutputEncoding = Encoding.UTF8;

List<LearningItem > myStudyList = new List<LearningItem>();

myStudyList.Add(new Kanji("水", "スイ", "みず", "Nước", 4, "N5"));
myStudyList.Add(new Kanji("火", "カ", "ひ", "Lửa", 4, "N5"));

myStudyList.Add(new Vocabulary("がくせい (Gakusei)", "Sinh viên"));
myStudyList.Add(new Vocabulary("せんせい (Sensei)", "Giáo viên"));
Kanji k = new Kanji("木", "モク", "き", "Cây", 4, "N5");
k.Display();
k.Display(true);
k.Display(false);
foreach (LearningItem item in myStudyList)
{
    item.Display();
}
static void ShowSummary(List<LearningItem> items)
{
    int KanjiCount = items.OfType<Kanji>().Count();
    int VocabularyCount = items.OfType<Vocabulary>().Count();
    Console.WriteLine($"Số lượng Kanji: {KanjiCount}");
    Console.WriteLine($"Số lượng Vocabulary: {VocabularyCount}");
}
ShowSummary(myStudyList);