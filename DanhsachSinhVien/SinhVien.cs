using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhsachSinhVien
{
    internal class SinhVien
    {
        public string HoTen { get; set; }
        public string MSSV { get; set; }
        public double DiemTrungBinh { get; set; }

        public void NhapThongTin()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap MSSV: ");
            MSSV = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            DiemTrungBinh = Convert.ToDouble(Console.ReadLine());
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Ho ten: {HoTen}, MSSV: {MSSV}, Điem trung binh: {DiemTrungBinh}");
        }
    }
}
