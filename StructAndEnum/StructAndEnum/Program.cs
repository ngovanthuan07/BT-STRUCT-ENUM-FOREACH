using System;
using System.ComponentModel;

namespace StructAndEnum
{
    class Program
    {
        struct SinhVien_264
        {
            public string TruongDaiHoc_264;
            public string MSV_264;
            public string HoTen_264;
            public string Lop_264;
            public double DiemToan_264;
            public double DiemLy_264;
            public double DiemHoa_264;
        }
        public enum TruongDaiHoc
        {
            [Description("ĐẠI HỌC SƯU PHẠM KỸ THUẬT ĐÀ NẴNG")]
            V1 = 1,
        }

        public static string ToDescriptionString(TruongDaiHoc val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }


        static void NhapThongTinSinhVien(out SinhVien_264 SV)
        {
            SV.TruongDaiHoc_264 = ToDescriptionString(TruongDaiHoc.V1);
            Console.Write(" Ma sv: ");
            SV.MSV_264 = Console.ReadLine();
            Console.Write(" Ho ten: ");
            SV.HoTen_264 = Console.ReadLine();
            Console.Write(" Diem lop: ");
            SV.Lop_264 = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV.DiemToan_264 = double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.DiemLy_264 = double.Parse(Console.ReadLine());
            Console.Write(" Diem hoa: ");
            SV.DiemHoa_264 = double.Parse(Console.ReadLine());


        }

        static void XuatThongTinSinhVien(SinhVien_264[] SV)
        {
            foreach (SinhVien_264 s in SV)
            {
                Console.WriteLine(" Truong Dai Hoc: " + s.TruongDaiHoc_264);
                Console.WriteLine(" Ma sv: " + s.MSV_264);
                Console.WriteLine(" Ho ten: " + s.HoTen_264);
                Console.WriteLine(" Diem toan: " + s.DiemToan_264);
                Console.WriteLine(" Diem ly: " + s.DiemLy_264);
                Console.WriteLine(" Diem hoa: " + s.DiemHoa_264);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong phan tu: ");
            int n_264 = int.Parse(Console.ReadLine());
            SinhVien_264[] sv_264 = new SinhVien_264[n_264];

            for(int i = 0; i < sv_264.Length; i++)
            {
                SinhVien_264 mySinhVien = new SinhVien_264();
                NhapThongTinSinhVien(out mySinhVien);
                sv_264[i] = mySinhVien;
            }
            Console.WriteLine("Xuat Thong Tin Sinh Vien: ");
            XuatThongTinSinhVien(sv_264);




        }
    }
}
