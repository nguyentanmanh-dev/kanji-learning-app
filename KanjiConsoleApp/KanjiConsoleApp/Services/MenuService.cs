using KanjiConsoleApp.Interfaces;
using KanjiConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace KanjiConsoleApp.Services
{
    public class MenuService
    {
        private readonly ILearningRepository _repository;
        public MenuService(ILearningRepository repository)
        {
            _repository = repository;
        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n===== KANJI LEARNING APP =====");
                Console.WriteLine("1. Thêm Kanji");
                Console.WriteLine("2. Thêm Từ vựng");
                Console.WriteLine("3. Xem danh sách");
                Console.WriteLine("4. Tìm kiếm");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": AddKanji(); break;
                    case "2": AddVocabulary(); break;
                    case "3": ShowAll(); break;
                    case "4": SearchItems(); break;
                    case "5": running = false; break;
                    default : Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại."); break;
                }
            }    
        }
        private void AddKanji()
        {
            Console.Write("Chữ Kanji: ");
            var character = Console.ReadLine();
            Console.Write("Âm On: ");
            var onYomi = Console.ReadLine();
            Console.Write("Âm Kun: ");
            var kunYomi = Console.ReadLine();
            Console.Write("Nghĩa: ");
            var meaning = Console.ReadLine();
            Console.Write("Số nét: ");
            var strokeInput = Console.ReadLine();
            Console.Write("JLPT Level: ");
            var jlptLevel = Console.ReadLine();
            try
            {
                int strokeCount = int.Parse(strokeInput ?? "0");
                var kanji = new Kanji(character, onYomi, kunYomi, meaning, strokeCount, jlptLevel);
                _repository.Add(kanji);
                Console.WriteLine("Đã thêm kanji thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
        private void AddVocabulary()
        {
            Console.Write("Từ vựng: ");
            var word = Console.ReadLine();
            Console.Write("Nghĩa: ");
            var meaning = Console.ReadLine();
            var vocab = new Vocabulary(word, meaning);
            _repository.Add(vocab);
            Console.WriteLine("Đã thêm từ vựng thành công!");
        }
        private void ShowAll()
        {
            var items = _repository.GetAll();
            if (!items.Any())
            {
                Console.WriteLine("Danh sách trống.");
                return;
            }
            foreach (var item in items)
            {
                item.Display();
            }
        }
        private void SearchItems()
        {
            Console.Write("Nhập từ khóa tìm kiếm: ");
            var keyword = Console.ReadLine() ?? "";
            var results = _repository.Search(keyword);
            if (!results.Any())
            {
                Console.WriteLine("Không tìm thấy kết quả.");
                return;
            }
            foreach (var item in results)
            {
                item.Display();
            }
        }
    }
}
