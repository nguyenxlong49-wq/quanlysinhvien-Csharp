# Quản Lý Sinh Viên (C#)

Chương trình console đơn giản viết bằng C# (.NET Framework) dùng để nhập thông tin sinh viên, tính điểm trung bình, tìm sinh viên có điểm cao nhất và thống kê số lượng sinh viên đạt.

## Tính năng

- Nhập số lượng sinh viên (có kiểm tra hợp lệ, số lượng phải là số nguyên không âm)
- Nhập họ tên và điểm cho từng sinh viên (điểm phải trong khoảng 0–10, có kiểm tra hợp lệ)
- Tính điểm trung bình của cả lớp
- Tìm sinh viên có điểm số cao nhất
- Đếm số sinh viên đạt (điểm ≥ 5)
- In bảng danh sách sinh viên (STT, họ tên, điểm) được canh chỉnh gọn gàng

## Công nghệ

- **Ngôn ngữ:** C#
- **Framework:** .NET Framework 4.7.2
- **Loại project:** Console Application

## Cấu trúc project

```
quanlysinhvien-Csharp/
├── project.sln              # File solution của Visual Studio
└── project/
    ├── Program.cs            # Toàn bộ logic chương trình (class SinhVien + Main)
    ├── App.config
    ├── project.csproj
    └── Properties/
        └── AssemblyInfo.cs
```

## Cách chạy

### Dùng Visual Studio
1. Clone repo về máy:
   ```
   git clone https://github.com/nguyenxlong49-wq/quanlysinhvien-Csharp.git
   ```
2. Mở file `project.sln` bằng Visual Studio.
3. Nhấn **F5** hoặc **Start** để build và chạy chương trình.

### Dùng dòng lệnh (MSBuild)
```
msbuild project.sln
project\bin\Debug\project.exe
```

> Lưu ý: Vì project dùng .NET Framework 4.7.2, cần chạy trên Windows có cài .NET Framework tương ứng (hoặc Mono trên Linux/macOS).

## Ví dụ sử dụng

```
Hãy nhập số lượng sinh viên: 2

           Thông tin sinh viên
Nhập họ tên sinh viên 1 : Nguyen Van A
Điểm : 8.5
Nhập họ tên sinh viên 2 : Tran Thi B
Điểm : 4

                Thống kê
Điểm trung bình trong lớp : 6.25
Sinh viên có điểm số cao nhất : Nguyen Van A
Số lượng sinh viên đạt : 1/2

           Danh Sách Sinh Viên
===========================================
| STT   | Họ tên               |     Điểm |
===========================================
| 1     | Nguyen Van A         |     8.50 |
| 2     | Tran Thi B           |     4.00 |
===========================================
```

## Hướng phát triển thêm

- Tách class `SinhVien` ra file riêng
- Cho phép xuất danh sách ra file (CSV/Excel)
- Thêm chức năng sắp xếp danh sách theo điểm
- Viết lại bằng WinForms/WPF để có giao diện đồ họa

