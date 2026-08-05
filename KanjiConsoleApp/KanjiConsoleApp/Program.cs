using KanjiConsoleApp.Models;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<LearningItem > myStudyList = new List<LearningItem>();

myStudyList.Add(new Kanji("水", "スイ", "みず", "Nước", 4, "N5"));
myStudyList.Add(new Kanji("火", "カ", "ひ", "Lửa", 4, "N5"));

// 3. Thêm Vocabulary (Lớp con 2)
myStudyList.Add(new Vocabulary("がくせい (Gakusei)", "Sinh viên"));
myStudyList.Add(new Vocabulary("せんせい (Sensei)", "Giáo viên"));

Console.WriteLine("=== DANH SÁCH HỌC TẬP HÔM NAY ===\n");

// 4. Vòng lặp Đa hình (Polymorphism)
foreach (LearningItem item in myStudyList)
{
    // Chỉ gọi 1 hàm duy nhất, nhưng mỗi object sẽ tự biết cách in ra kiểu của nó
    item.Display();
}

try
{
    Kanji kLoi = new Kanji("", "", "", "test", 1, "N5");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Lỗi bắt được: {ex.Message}");
}