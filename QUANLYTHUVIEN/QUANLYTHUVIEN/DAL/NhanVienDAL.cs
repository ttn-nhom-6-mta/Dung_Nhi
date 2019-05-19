
using QUANLYTHUVIEN.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN.DAL
{
    public class DALNhanVien : ClassConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("select * from NhanVien");
        }
        public bool Them(NhanVienDAO nv)
        {
            try
            {
                string query = @"INSERT INTO dbo.nhanvien(  MaNhanVien ,TenNhanVien ,NgaySinhNV ,GioiTinhNV ,DiaChiNV,SDTNV)
                                VALUES  ( '" + nv.Manv + "',N'" + nv.Ten + "','" + nv.NgaySinh + "', N'" + nv.GioiTinh + "',N'" + nv.DiaChi + "','" + nv.SDT + "')";
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
        public bool Sua(NhanVienDAO nv)
        {
            try
            {
                string query = @"UPDATE NhanVien set TenNhanVien=N'" + nv.Ten + "', NgaySinhNV='" + nv.NgaySinh + "', GioiTinhNV=N'" + nv.GioiTinh + "',DiaChiNV=N'" + nv.DiaChi + "',SDTNV=" + nv.SDT + " WHERE MANhanVien='" + nv.Manv + "'";
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
        public bool Xoa(string _MaNhanVien)
        {
            try
            {
                string query = @"Delete from NhanVien where MaNhanVien='" + _MaNhanVien + "'";
                OpenConection();
                //ExecuteQueries(@"DELETE FROM PhieuMuonTra WHERE MaNhanVien = '" + _MaNhanVien + "'");
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
                string query = @"select * from NhanVien where (MaNhanVien like '%" + chuoi + "%') or (TenNhanVien like N'%" + chuoi + "%') or (GioiTinhNV like N'%" + chuoi + "%') or (DiaChiNV like N'%" + chuoi + "%') or SDTNV like '%" + chuoi + "%'";
                return (DataTable)ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return null;
            }
            // }

        }
    }
}
