
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
                                VALUES  ( '" + nv.MaNhanVien + "',N'" + nv.TenNhanVien + "','" + nv.NgaySinhNV + "', N'" + nv.GioiTinhNV + "',N'" + nv.DiaChiNV + "','" + nv.SDTNV + "')";
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
                string query = @"UPDATE dbo.NhanVien set TENNhanVien=N'" + nv.TenNhanVien + "', NgaySinhNV='" + nv.NgaySinhNV + "', GioiTinhNV=N'" + nv.GioiTinhNV + "',DiaChiNV=N'" + nv.DiaChiNV + "',SDTNV=" + nv.SDTNV + " WHERE MANhanVien='" + nv.MaNhanVien + "'";
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
        public bool Xoa(String ma)
        {
            try
            {
                string query = @"Delete from NhanVien where MaNhanVien='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"DELETE FROM PhieuMuon WHERE MaNhanVien = '" + ma + "'");
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
