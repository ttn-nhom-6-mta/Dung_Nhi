
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUVIEN.GUI
{
    public partial class Login : Form
    {
        string Strcon = @"Data Source=DESKTOP-QPR5C5O\SQLEXPRESS;Initial Catalog=QUANLYTHUVIEN;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    

        private void btDangNhap_Click(object sender, EventArgs e)
        {

            try
            {
                conn = new SqlConnection(Strcon);
                conn.Open();
                string sql = "select count(*)  from Login where MaNhanVien= @taikhoan and MatKhau= @matkhau";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@taikhoan", txtTaiKhoan.Text));
                cmd.Parameters.Add(new SqlParameter("@matkhau", txtMatKhau.Text));

                int x = (int)cmd.ExecuteScalar();
                if (x == 1)
                {
                    // MessageBox.Show("thành công");
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập thất bại");
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtTaiKhoan.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {

            DialogResult bt = MessageBox.Show("Bạn muốn thoát không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (bt == DialogResult.OK)
                Application.Exit();

        }

        private void checkMK_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkMK_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkMK.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

            private void frmLogin_Load(object sender, EventArgs e)
            {

            }
        }
}
