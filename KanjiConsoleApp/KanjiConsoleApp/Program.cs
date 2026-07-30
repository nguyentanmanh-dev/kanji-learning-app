using KanjiConsoleApp.Models;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Kanji k1 = new Kanji("水", "スイ", "みず", "nước", 4, "N5");
Kanji k2 = new Kanji("火", "カ", "ひ", "lửa", 4, "N5");

k1.Display();
k2.Display();

foreach (var kanji in new List<Kanji> { k1, k2 })
{
    Console.WriteLine($"Kanji: {kanji.Character}, JLPT Level: {kanji.JlptLevel}");
}

try
{
    Kanji kLoi = new Kanji("", "", "", "test", 1, "N5");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Lỗi bắt được: {ex.Message}");
}