using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect(); //Mở kết nối
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            Forms.frmDMChatLieu f = new Forms.frmDMChatLieu();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            Forms.frmDMHang f = new Forms.frmDMHang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            Forms.frmDMKhachHang f = new Forms.frmDMKhachHang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            Forms.frmDMNhanvien f = new Forms.frmDMNhanvien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
       private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            Forms.frmHoaDonBan f = new Forms.frmHoaDonBan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            Forms.frmTimHDBan f = new Forms.frmTimHDBan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuFindHang_Click(object sender, EventArgs e)
        {
            Forms.frmDMChatLieu f = new Forms.frmDMChatLieu();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuFindKhachHang_Click(object sender, EventArgs e)
        {
            Forms.frmDMKhachHang f = new Forms.frmDMKhachHang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuHoaDonBan_Click_1(object sender, EventArgs e)
        {
            Forms.frmHoaDonBan f = new Forms.frmHoaDonBan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            Forms.frmHoaDonBan f = new Forms.frmHoaDonBan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
