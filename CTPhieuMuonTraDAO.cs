using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DAO
{
    class CTPhieuMuonTraDAO
    {
        public string MaPhieuMuonTra { get; set; }
        public string MaCuonSach { get; set; }
        public string MaVP { get; set; }
        public string TinhTrangTra { get; set; }

        public CTPhieuMuonTraDAO (string MaPhieuMuonTra, string MaCuonSach, string MaVP, string TinhTrangTra)
        {
            this.MaPhieuMuonTra = MaPhieuMuonTra;
            this.MaCuonSach = MaCuonSach;
            this.MaVP = MaVP;
            this.TinhTrangTra = TinhTrangTra;
        }
    }
}
