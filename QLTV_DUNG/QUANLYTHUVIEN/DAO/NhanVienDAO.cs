using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN.DAO
{
    public class NhanVienDAO
    {
        public string MaNhanVien { set; get; }

        public string TenNhanVien { set; get; }

        public DateTime NgaySinhNV { set; get; }

        public string GioiTinhNV { set; get; }

        public string DiaChiNV { set; get; }

        public string SDTNV { set; get; }

        public NhanVienDAO(string _MaNhanVien, string _TenNhanVien, DateTime _NgaySinhNV, string _GioiTinhNV, string _DiaChiNV, string _SDTNV)
        {
            this.MaNhanVien = _MaNhanVien;
            this.TenNhanVien = _TenNhanVien;
            this.NgaySinhNV = _NgaySinhNV;
            this.GioiTinhNV = _GioiTinhNV;
            this.DiaChiNV = _DiaChiNV;
            this.SDTNV = _SDTNV;
        }
        public NhanVienDAO()
        {

        }
    }
}
