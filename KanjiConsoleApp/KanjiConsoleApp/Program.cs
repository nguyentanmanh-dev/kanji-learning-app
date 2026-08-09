using KanjiConsoleApp.Models;
using System.Text;
using System.Linq;
using KanjiConsoleApp.Interfaces;
using KanjiConsoleApp.Repositories;
using KanjiConsoleApp.Services; 

Console.OutputEncoding = Encoding.UTF8;

ILearningRepository repository = new LearningRepository();
MenuService menu = new MenuService(repository);
menu.Run();