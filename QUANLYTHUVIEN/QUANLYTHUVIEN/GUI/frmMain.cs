using QUANLYTHUVIEN.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUVIEN.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tsLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frm = new Login();
            frm.Show();
        }

        private void tsNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
            NhanVien frmnv = new NhanVien();
            frmnv.Show();
        }

        private void ttPhongBan_Click(object sender, EventArgs e)
        {
            this.Close();
            DocGia dg = new DocGia();
            dg.Show();
        }
    }
}
