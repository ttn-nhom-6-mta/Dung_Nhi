using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.BUS;
using QUANLYTHUVIEN.DAL;
using QUANLYTHUVIEN.DAO;

namespace QUANLYTHUVIEN.GUI
{
    public partial class DocGia : Form
    {
        public DocGia()
        {
            InitializeComponent();
            ShowData();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {

        }
        DocGiaBUS dg1 = new DocGiaBUS();
        void FormatData()
        {
            txtsothe.Text = "";
            txthoten.Text = "";

            txtsdt.Text = "";
            txtdiachi.Text = "";


            rdnam.Checked = false;
            rdnu.Checked = false;
        }
        void ShowData()
        {
            dtgvdocgia.DataSource = dg1.GetData();
        }
        string type;

        private void btthem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (txtsothe.Text != "" && txthoten.Text != "" && txtsdt.Text != "" && txtdiachi.Text != "")
                {
                    string gioitinh = "";
                    if (rdnam.Checked)
                    {
                        gioitinh = "Nam";
                    }
                    else
                    {
                        gioitinh = "Nữ";
                    }

                    DocGiaDAOcs dg = new DocGiaDAOcs(txtsothe.Text.ToString().Trim(), txthoten.Text.ToString().Trim(), dtngaysinh.Text.Trim(), gioitinh, txtdiachi.Text.ToString().Trim(), txtsdt.Text.ToString());
                    //(txtMaNV.Text.ToString().Trim(), txtTen.Text.ToString().Trim(), txtMaPhong.Text.ToString().Trim(),DateTime.Parse(dtNgaySinh.Text.ToString()),gioitinh,int.Parse(txtLuong.Text.ToString()), txtDiaChi.Text.ToString().Trim());
                    if (dg1.Them(dg) == true)
                    {
                        // FormatData();
                        ShowData();
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        Exception ex = dg1.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin độc giả");
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (txtsothe.Text != "" && txthoten.Text != "" && txtsdt.Text != "" && txtdiachi.Text != "")
                {
                    string gioitinh = "";
                    if (rdnam.Checked)
                    {
                        gioitinh = "Nam";
                    }
                    else
                    {
                        gioitinh = "Nữ";
                    }

                    DocGiaDAOcs dg = new DocGiaDAOcs(txtsothe.Text.ToString().Trim(), txthoten.Text.ToString().Trim(), dtngaysinh.Text.Trim(), gioitinh, txtdiachi.Text.ToString().Trim(), txtsdt.Text.ToString().Trim());
                    if (dg1.Sua(dg) == true)
                    {
                        FormatData();
                        ShowData();

                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        Exception ex = dg1.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin độc giả");
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (txtsothe.Text.Length != 0)
            {
                string query = @"DELETE FROM dbo.DocGia Where SoThe='" + txtsothe.Text + "'";
                if (MessageBox.Show("Bạn chắc muốn xóa độc giả không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dg1.Xoa(txtsothe.Text.Trim()))
                    {
                        FormatData();
                        ShowData();

                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        Exception ex = dg1.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Lỗi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn");
            }
        }

        private void bthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text != "")
            {
                bthienthi.Enabled = true;
                if (dg1.GetDataTimKiem(txttimkiem.Text.Trim()) != null)
                {
                    FormatData();
                    dtgvdocgia.DataSource = dg1.GetDataTimKiem(txttimkiem.Text.Trim());
                    // MessageBox.Show("Tìm thành công");
                }
                else
                {
                    Exception ex = dg1.GetEx();
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Lỗi rồi bạn ơi !");
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }

        private void bthienthi_Click(object sender, EventArgs e)
        {
            bthienthi.Enabled = false;
            txttimkiem.Text = "";
            ShowData();
        }

        private void dtgvdocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvdocgia.Rows[e.RowIndex];
                txtsothe.Text = row.Cells[0].Value.ToString().Trim();
                txthoten.Text = row.Cells[1].Value.ToString().Trim();

                dtngaysinh.Text = row.Cells[2].Value.ToString().Trim();
                if (row.Cells[3].Value.ToString().Trim() == "Nam")
                {
                    rdnam.Checked = true;
                }
                else if (row.Cells[3].Value.ToString().Trim() == "Nữ")
                    rdnu.Checked = true;

                txtsdt.Text = row.Cells[5].Value.ToString().Trim();
                txtdiachi.Text = row.Cells[4].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                ex = dg1.GetEx();
                MessageBox.Show(ex.Message);
                MessageBox.Show("Có lỗi xảy ra");
            }
        }
    }
}
