# Kanji Learning Console App

Ứng dụng console giúp học và ôn tập Kanji tiếng Nhật, được xây dựng trong quá trình 
tự học Backend .NET. Đây là bước khởi đầu cho project lớn hơn: Kanji Learning API 
(sẽ phát triển tiếp với ASP.NET Core, EF Core, thuật toán Spaced Repetition).

## Tính năng
- Thêm/xem/tìm kiếm Kanji và Từ vựng
- Áp dụng OOP: Encapsulation, Inheritance, Polymorphism (Interface + Abstract Class)
- Tổ chức code theo Repository Pattern, Dependency Injection thủ công

## Công nghệ sử dụng
- C#, .NET 8
- Console Application

## 📂 Kiến trúc project
```text
KanjiConsoleApp/
├── Models/          # Chứa các thực thể dữ liệu: Kanji, Vocabulary, LearningItem (abstract)
├── Interfaces/      # Chứa các hợp đồng giao tiếp: ILearningRepository
├── Repositories/    # Xử lý nghiệp vụ lưu trữ dữ liệu (in-memory với List<T>)
├── Services/        # Logic tương tác người dùng và điều phối ứng dụng (MenuService)
└── Program.cs       # Entry point, khởi tạo cấu hình Encoding và tiêm Dependency Injection

## Cách chạy
1. Clone repo: `git clone https://github.com/nguyentanmanh-dev/kanji-learning-app.git`
2. Mở bằng Visual Studio hoặc chạy: `dotnet run` trong thư mục `KanjiConsoleApp`
3. Làm theo menu hiển thị trên màn hình

## Định hướng phát triển tiếp theo
- [ ] Chuyển từ lưu in-memory sang SQL Server + EF Core
- [ ] Xây dựng ASP.NET Core Web API
- [ ] Thêm thuật toán Spaced Repetition (SM-2)
- [ ] Deploy lên cloud

## Tác giả
Nguyễn Tấn Mạnh — Sinh viên BK-HCM, đang theo hướng Backend .NET Developer