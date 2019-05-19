using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN.DAO
{
    public class NhanVienDAO
    {
        private string MaNhanVien;

        public string Manv
        {
            get { return MaNhanVien; }
            set { MaNhanVien = value; }
        }
        private string TenNhanVien;

        public string Ten
        {
            get { return TenNhanVien; }
            set { TenNhanVien = value; }
        }
        private DateTime NgaySinhNV;

        public DateTime NgaySinh
        {
            get { return NgaySinhNV; }
            set { NgaySinhNV = value; }
        }
        private string GioiTinhNV;

        public string GioiTinh
        {
            get { return GioiTinhNV; }
            set { GioiTinhNV = value; }
        }
       
        private string DiaChiNV;

        public string DiaChi
        {
            get { return DiaChiNV; }
            set { DiaChiNV = value; }
        }
        private string SDTNV;

        public string SDT
        {
            get { return SDTNV; }
            set { SDTNV = value; }
        }

        public NhanVienDAO(string _MaNhanVien, string _TenNhanVien, DateTime _NgaySinhNV, string _GioiTinhNV, string _DiaChiNV, string _SDTNV)
        {
            this.MaNhanVien = _MaNhanVien;
            this.TenNhanVien = _TenNhanVien;
            this.NgaySinhNV = _NgaySinhNV;
            this.GioiTinhNV = _GioiTinhNV;
            this.DiaChiNV = _DiaChiNV;
            this.SDTNV = _SDTNV;
        }
       // public NhanVienDAO()
        //{

        //}
    }
}
