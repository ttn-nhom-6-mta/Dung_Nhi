using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN.DAO
{
    public class DocGiaDAO
    {
        public string SoThe { set; get; }

        public string Hoten { set; get; }

        public DateTime Ngaysinh { set; get; }

        public string Gioitinh { set; get; }

        public string Diachi { set; get; }

        public string SDT { set; get; }

        public DocGiaDAO(string _SoThe, string Hoten, DateTime _Ngaysinh, string gioitinh, string _diachi, string _lop)
        {
            this.SoThe = _SoThe;
            this.Hoten = Hoten;
            this.Ngaysinh = _Ngaysinh;
            this.Gioitinh = gioitinh;
            this.Diachi = _diachi;
            this.SDT = _lop;
        }
        public DocGiaDAO()
        {

        }
    }
}