using KanjiConsoleApp.Models;
using System.Text;
using System.Linq;
using KanjiConsoleApp.Interfaces;
using KanjiConsoleApp.Repositories;
using KanjiConsoleApp.Services;
using KanjiConsoleApp.Repositories;

Console.OutputEncoding = Encoding.UTF8;

ILearningRepository repository = new LearningRepository();
MenuService menu = new MenuService(repository);
menu.Run();

var repo = new LearningRepository();
repo.Add(new Kanji("水", "スイ", "みず", "nước", 4, "N5"));
repo.Add(new Kanji("火", "カ", "ひ", "lửa", 4, "N5"));
repo.Add(new Kanji("木", "モク", "き", "cây", 4, "N5"));
repo.Add(new Kanji("金", "キン", "かね", "vàng/tiền", 8, "N4"));
repo.Add(new Kanji("土", "ド", "つち", "đất", 3, "N5"));

Console.WriteLine("Danh sách Kanji có số nét >= 4:");
var ketqua1 = repo.GetCharactersWithMinStroke(4);
foreach (var character in ketqua1)
{
    Console.Write($"{character}, ");
}

Console.WriteLine("\n=== Danh sách tất cả các chữ Kanji ===");
var ketQua2 = repo.GetAllCharacters();
Console.WriteLine(string.Join(", ", ketQua2));