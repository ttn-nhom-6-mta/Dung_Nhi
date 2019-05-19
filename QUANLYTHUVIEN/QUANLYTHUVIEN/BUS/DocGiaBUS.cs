using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QUANLYTHUVIEN.DAO;
using QUANLYTHUVIEN.DAL;

namespace QUANLYTHUVIEN.BUS
{
    public class DocGiaBUS
    {

        DocGiaDAL dg1 = new DocGiaDAL();
        public DataTable GetData()
        {
            return dg1.GetData();
        }
        public bool Them(DocGiaDAOcs dg)
        {
            return dg1.Them(dg);
        }
        public bool Sua(DocGiaDAOcs dg)
        {
            return dg1.Sua(dg);
        }
        public Exception GetEx()
        {
            return dg1.GetEx();
        }
        public void SetEx(Exception ex)
        {

        }
        public bool Xoa(string so)
        {
            return dg1.Xoa(so);
        }
        public DataTable GetDataTimKiem(string chuoi)
        {
            return dg1.GetDataTimKiem(chuoi);
        }
    }
}

