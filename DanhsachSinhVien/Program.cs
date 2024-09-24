using System;
namespace DanhsachSinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            DsSinhVien dsSinhVien = new DsSinhVien();
            Console.WriteLine("Nhap So luong Sinh Vien:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                SinhVien sv = new SinhVien();
                sv.NhapThongTin();
                dsSinhVien.ThemSinhVien(sv);
            }

            Console.WriteLine("\nDanh Sach Sinh Vien:");
            dsSinhVien.HienThiDanhSach();

            SinhVien svCaoNhat = dsSinhVien.TinhDiemTrungBinhCaoNhat();
            if (svCaoNhat != null)
            {
                Console.WriteLine("\nSinh vien co diem trung binh cao nhat:");
                svCaoNhat.HienThiThongTin();
            }

            Console.Write("\nNhap MSSV de tim kiem: ");
            string mssvTimKiem = Console.ReadLine();
            dsSinhVien.TimSinhVienTheoMSSV(mssvTimKiem);

            Console.ReadLine();
        }
    }
}
