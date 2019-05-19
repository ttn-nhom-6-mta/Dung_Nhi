using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DAO
{
    class PhieuMuonTraDAO
    {
        public string MaPhieuMuonTra { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayHenTra { get; set; }
        public DateTime NgayTra { get; set; }
        public string SoThe { get; set; }
        public string MaNhanVien { get; set; }

        public PhieuMuonTraDAO(string MaPhieuMuonTra, DateTime NgayMuon, DateTime NgayHenTra, DateTime NgayTra, string SoThe, string MaNhanVien)
        {
            this.MaPhieuMuonTra = MaPhieuMuonTra;
            this.NgayMuon = NgayMuon;
            this.NgayHenTra = NgayHenTra;
            this.NgayTra = NgayTra;
            this.SoThe = SoThe;
            this.MaNhanVien = MaNhanVien;
        }
    }
}
