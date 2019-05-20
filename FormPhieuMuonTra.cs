using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.BUS;
using QLTV.DAO;

namespace QLTV.GUI
{
    public partial class FormPhieuMuonTra : Form
    {
        public FormPhieuMuonTra()
        {
            InitializeComponent();
            HienThi();
            LoadCombobox();
        }

        QuanLyThuVienEntities dt = new QuanLyThuVienEntities();
        PhieuMuonTraBUS BUSPhieu = new PhieuMuonTraBUS();
        DocGiaBUS BUSDG = new DocGiaBUS();
        NhanVienBUS BUSNV = new NhanVienBUS();

        private void HienThi()
        {
            //string SqlSelect = "SELECT * FROM ChiTietPhieuMuonTra";
            dataGridView1.DataSource = BUSPhieu.GetDataPMT();
        }

        private void LoadCombobox()
        {
            var model = from p in dt.NhanViens select p;
            foreach (NhanVien item in model)
                cboTNV.Items.Add(item.TenNhanVien);
        }

        private void btnTKPMT_Click(object sender, EventArgs e)
        {
            if (txtTKPMT.Text != "")
            {
                if (BUSPhieu.GetDataTableTimKiem(txtTKPMT.Text.Trim()) != null)
                {
                    dataGridView1.DataSource = BUSPhieu.GetDataTableTimKiem(txtTKPMT.Text);
                }
                else
                {
                    MessageBox.Show("Lỗi rồi bạn ơi !");
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }

        private void btnThemPMT_Click(object sender, EventArgs e)
        {
            if (txtIDP.Text != "" && dateNM.Text != "" && dateNHT.Text != "" && dateNT.Text != "" && txtIDDG.Text != "" && cboTNV.Text != "" && txtIDNV.Text != "")
            {
                PhieuMuonTraDAO ct = new PhieuMuonTraDAO(txtIDP.Text.ToString().Trim(), DateTime.Parse(dateNM.Text.ToString()), DateTime.Parse(dateNHT.Text.ToString()), DateTime.Parse(dateNT.Text.ToString()), txtIDDG.Text.ToString().Trim(), txtIDNV.Text.ToString().Trim());
                if (BUSPhieu.ThemPMT(ct) == true)
                {
                    HienThi();
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin chi tiết");
            }
        }

        private void btnSuaPMT_Click(object sender, EventArgs e)
        {
            if (txtIDP.Text != "" && dateNM.Text != "" && dateNHT.Text != "" && dateNT.Text != "" && txtIDDG.Text != "" && cboTNV.Text != "" && txtIDNV.Text != "")
            {
                PhieuMuonTraDAO ct = new PhieuMuonTraDAO(txtIDP.Text.ToString().Trim(), DateTime.Parse(dateNM.Text.ToString()), DateTime.Parse(dateNHT.Text.ToString()), DateTime.Parse(dateNT.Text.ToString()), txtIDDG.Text.ToString().Trim(), txtIDNV.Text.ToString().Trim());
                if (BUSPhieu.SuaPMT(ct) == true)
                {
                    HienThi();
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin chi tiết");
            }
        }

        private void btnXoaPMT_Click(object sender, EventArgs e)
        {
            if (txtIDP.Text.Length != 0)
            {
                //string query = @"DELETE FROM ChiTietPhieuMuonTra WHERE MaPhieuMuonTra = '" + txtIDP.Text + "' DELETE FROM PhieuMuonTra WHERE MaPhieuMuonTra ='" + txtIDP.Text + "'";
                if (MessageBox.Show("Bạn chắc chắn muốn xóa ???", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (BUSPhieu.XoaPMT(txtIDP.Text.Trim()) == true)
                    {
                        HienThi();
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormCTPhieuMuonTra frm = new FormCTPhieuMuonTra();
            frm.Show();
        }

        private void cboTNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;

            var IDNV = from p in dt.NhanViens.Where(p => p.TenNhanVien == combo.SelectedItem.ToString()) select p;
            foreach (NhanVien item in IDNV)
                txtIDNV.Text = item.MaNhanVien;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateNM.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateNHT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateNT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtIDDG.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cboTNV.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtIDNV.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
