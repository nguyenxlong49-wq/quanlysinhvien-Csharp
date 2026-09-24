using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class SinhVien
    {
        public static double TinhDiemTrungBinh(double sum,int n )
        {
            return sum / n;
        }
        public string  hoten;
        public double diem;

    }
    internal class Program
    {
 
        static string Center(string text, int width)
        {
            int left = (width - text.Length) / 2;
            int right = width - text.Length - left;

            return new string(' ', left) + text + new string(' ', right);
        }
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            int n = 0;
            while (true)
            {
                Console.Write("Hãy nhập số lượng sinh viên: ");
                 n = int.Parse(Console.ReadLine());
                if (n >= 0 && n <= 10)
                {
                    break;
                }

                Console.WriteLine("Không hợp lệ,vui lòng nhập lại !");
            }
            Console.WriteLine();
            double sum = 0;
            int pos = 0;
            SinhVien MaxSV = null;
            List<SinhVien> ds = new List<SinhVien>();
            Console.WriteLine(Center("Thông tin sinh viên", 40));
            for (int i = 1; i <= n; i++)
            {
                SinhVien sv = new SinhVien();
                Console.Write($"Nhập họ tên sinh viên {i} : ");
                sv.hoten = Console.ReadLine();
                while (true)
                {
                    Console.Write("Điểm : ");
                    
                    if(double.TryParse(Console.ReadLine(), out sv.diem)
                        && sv.diem >= 0
                        && sv.diem <= 10)
                    {
                        break;
                    }
                    Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập lại!");
                }
                
                sum += sv.diem;
                if (MaxSV == null || sv.diem > MaxSV.diem)
                {
                    MaxSV = sv;
                }
                if(sv.diem >= 5)
                {
                    pos++;
                }
                ds.Add(sv);
            }
            Console.WriteLine();
            Console.WriteLine(Center("Thống kê", 40));
            double diemTb = SinhVien.TinhDiemTrungBinh(sum,n);
            Console.WriteLine($"Điểm trung bình trong lớp : {diemTb}");
            Console.WriteLine($"Sinh viên có điểm số cao nhất : {MaxSV.hoten}");
            Console.WriteLine($"Số lượng sinh viên đạt : {pos}/{n}");
            Console.WriteLine();
            Console.WriteLine(Center("Danh Sách Sinh Viên",40));
            Console.WriteLine("===========================================");
            Console.WriteLine("| {0,-5} | {1,-20} | {2,8} |",
            "STT", "Họ tên", "Điểm");
            Console.WriteLine("===========================================");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("| {0,-5} | {1,-20} | {2,8:F2} |",
                  i + 1,
                  ds[i].hoten,
                  ds[i].diem);
            }
            Console.WriteLine("===========================================");
        }
    }
}
