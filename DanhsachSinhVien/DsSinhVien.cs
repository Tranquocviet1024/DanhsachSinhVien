using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhsachSinhVien
{
    internal class DsSinhVien
    {
        private List<SinhVien> danhSach = new List<SinhVien>();

        public void ThemSinhVien(SinhVien sv)
        {
            danhSach.Add(sv);
        }

        public void HienThiDanhSach()
        {
            foreach (var sv in danhSach)
            {
                sv.HienThiThongTin();
            }
        }

        public void TimSinhVienTheoMSSV(string mssv)
        {
            var sinhVien = danhSach.Find(sv => sv.MSSV == mssv);
            if (sinhVien != null)
            {
                sinhVien.HienThiThongTin();
            }
            else
            {
                Console.WriteLine("Không tim thay.");
            }
        }

        public SinhVien TinhDiemTrungBinhCaoNhat()
        {
            if (danhSach.Count == 0)
            {
                return null;
            }
            SinhVien svMax = danhSach[0];
            foreach (var sv in danhSach)
            {
                if (sv.DiemTrungBinh > svMax.DiemTrungBinh)
                {
                    svMax = sv;
                }
            }
            return svMax;
        }
    }
}
