using System;

namespace DAO
{
    public class DAOThongKe
    {
        public string MaDauSach { get; set; }
        public string TenDauSach { get; set; }
        public string MaCuonSach { get; set; }
        public DateTime Ngay1 { get; set; }
        public DateTime Ngay2 { get; set; }
        public string SoLanMuon { get; set; }
        public string TinhTrangCuonSach { get; set; }
    }
    public DAOThongKe() 
    {
        MaDauSach = "";
        TenDauSach = "";
        MaCuonSach = "";
        Ngay1 = DateTime.Parse("01/01/2017");
        Ngay2 = DateTime.Parse("01/01/2017");
        SoLanMuon = "";
        TinhTrangCuonSach = "";
    }
    public DAOThongKe(string mads, string tends, string macs, DateTime ngay1, DateTime ngay2, string solanmuon, string tinhtrangcs )
    {
        this.MaDauSach = mads;
        this.TenDauSach = tends;
        this.MaCuonSach = macs;
        this.Ngay1 = ngay1;
        this.Ngay2 = ngay2;
        this.SoLanMuon = solanmuon;
        this.TinhTrangCuonSach = tinhtrangcs;
    }
}