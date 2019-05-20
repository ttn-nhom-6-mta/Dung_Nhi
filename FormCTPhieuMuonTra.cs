using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.DAO;
using QLTV.BUS;

namespace QLTV.GUI
{
    public partial class FormCTPhieuMuonTra : Form
    {
        public FormCTPhieuMuonTra()
        {
            InitializeComponent();
            HienThiCBO();
            HienThi();
        }

        QuanLyThuVienEntities dt = new QuanLyThuVienEntities();
        CTPhieuMuonTraBUS BUSChiTiet = new CTPhieuMuonTraBUS();
        ViPhamBUS BUSViPham = new ViPhamBUS();

        private void HienThi()
        {
            //string SqlSelect = "SELECT * FROM ChiTietPhieuMuonTra";
            dataGridView2.DataSource = BUSChiTiet.GetData();
        }

        private void HienThiCBO()
        {

            var model = from p in dt.PhieuMuonTras select p;
            foreach (PhieuMuonTra item in model)
                cboIDTT.Items.Add(item.MaPhieuMuonTra);

            var model1 = from p in dt.CuonSaches select p;
            foreach (CuonSach item in model1)
                cboTCS.Items.Add(item.MaCuonSach);

            var model2 = from p in dt.ViPhams select p;
            foreach (ViPham item in model2)
                cboTVP.Items.Add(item.TenVP);
        }

        private void cboTVP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;

            var IDVP = from p in dt.ViPhams.Where(p => p.TenVP == combo.SelectedItem.ToString()) select p;
            foreach (ViPham item in IDVP)
                txtIDVP.Text = item.MaVP;

            var TVP = from p in dt.ViPhams.Where(p => p.TenVP == combo.SelectedItem.ToString()) select p;
            foreach (ViPham item in TVP)
            {
                int a = Convert.ToInt32(item.TienVP);
                txtTVP.Text = a.ToString();
            }
        }

        private void btnTKTT_Click(object sender, EventArgs e)
        {
            if (txtCT.Text != "")
            {
                if (BUSChiTiet.GetDataTableTimKiemCT(txtCT.Text.Trim()) != null)
                {
                    dataGridView2.DataSource = BUSChiTiet.GetDataTableTimKiemCT(txtCT.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Lỗi rồi bạn ơi !");
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }

        private void btnThemTT_Click(object sender, EventArgs e)
        {
            if (cboIDTT.Text != "" && cboTCS.Text != "" && cboTVP.Text != "" && txtIDVP.Text != "" && txtTVP.Text != "" && txtTTT.Text != "")
            {
                CTPhieuMuonTraDAO ct = new CTPhieuMuonTraDAO(cboIDTT.Text.ToString().Trim(), cboTCS.Text.ToString().Trim(), txtIDVP.Text.ToString().Trim(), txtTTT.Text.ToString().Trim());
                if (BUSChiTiet.ThemCTPMT(ct) == true)
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

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            if (cboIDTT.Text != "" && cboTCS.Text != "" && cboTVP.Text != "" && txtIDVP.Text != "" && txtTVP.Text != "" && txtTTT.Text != "")
            {
                CTPhieuMuonTraDAO ct = new CTPhieuMuonTraDAO(cboIDTT.Text.ToString().Trim(), cboTCS.Text.ToString().Trim(), txtIDVP.Text.ToString().Trim(), txtTTT.Text.ToString().Trim());
                if (BUSChiTiet.SuaCTPMT(ct) == true)
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

        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            if (cboIDTT.Text.Length != 0)
            {
                string query = @"DELETE FROM ChiTietPhieuMuonTra WHERE MaPhieuMuonTra ='" + cboIDTT.Text + "'";
                if (MessageBox.Show("Bạn chắc chắn muốn xóa ???", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BUSChiTiet.XoaCTPMT(cboIDTT.Text.Trim(), cboTCS.Text.Trim());
                    MessageBox.Show("Xóa thành công");
                    HienThi();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormPhieuMuonTra frm = new FormPhieuMuonTra();
            frm.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboIDTT.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            cboTCS.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            cboTVP.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtIDVP.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtTVP.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txtTTT.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
