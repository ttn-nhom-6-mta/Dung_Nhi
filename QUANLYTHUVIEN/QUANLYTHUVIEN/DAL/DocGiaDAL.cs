using QUANLYTHUVIEN.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN.DAL
{
   public class DocGiaDAL : ClassConnection
    {

        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("select * from DocGia");
        }
        public bool Them(DocGiaDAOcs dg)
        {
            try
            {
                string query = @"INSERT INTO dbo.DocGia( SoThe,HoTen , NgaySinh ,GioiTinh,DiaChi,SDT)
                                VALUES  ( '" + dg.SoThe + "',N'" + dg.HoTen + "', CONVERT(DATE,'" + dg.NgaySinh + "',103),N'" + dg.GioiTinh + "', N'" + dg.DiaChi + "', '" + dg.SDT + "')";
                OpenConection();
                ExecuteQueries(query);
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return false;
            }
        }

        // public bool Them(DocGiaDAO docGiaDAO, object dg)
        // {
        //     throw new NotImplementedException();
        //  }

        public bool Sua(DocGiaDAOcs dg)
        {
            try
            {
                string query = @" UPDATE dbo.DocGia set HoTen = N'" + dg.HoTen + "',NgaySinh = CONVERT(DATE,'" + dg.NgaySinh + "',103) ,GioiTinh=N'" + dg.GioiTinh + "', DiaChi= N'" + dg.DiaChi + "', SDT='" + dg.SDT + "' where SoThe ='" + dg.SoThe + "'";
                OpenConection();
                ExecuteQueries(query);
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return false;
            }
        }
        public bool Xoa(String so)
        {
            try
            {
                string query = @"Delete from DocGia where SoThe='" + so + "'";
                OpenConection();
                //ExecuteQueries(@"DELETE FROM dbo.ChiTietPhieuMuonTra WHERE SoThe = '" + so + "'");

                ExecuteQueries(query);
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return false;
            }
        }
        public DataTable GetDataTimKiem(string chuoi)
        {
            try
            {
                //string query = @"select * from NhanVien where (manv like '%" + chuoi + "%' or ten like N'%" + chuoi + "%' or maphong like '%" + chuoi + "%' or gioitinh like N'%" + chuoi + "%' or luong like '%" + chuoi + "%'or diachi like N'%" + chuoi+ "% or ngaysinh like '%" + DateTime.Parse(chuoi) +"')";
                string query = @"select * from DocGia where (SoThe like '%" + chuoi + "%' or HoTen like N'%" + chuoi + "%' or DiaChi like '%" + chuoi + "%')";
                return (DataTable)ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return null;
            }
        }
    }
}

