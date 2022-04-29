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
using DevExpress.XtraEditors;

namespace Backup_Restore
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        //public Form form = new FormMain();
        public FormDangNhap()
        {
            InitializeComponent();
            txbServername.Text = "DESKTOP-O4NU276".Trim();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
   
            if (txbLoginName.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txbLoginName.Focus();
                return;
            }
            else if (txbPassWord.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu đăng nhập không được rỗng. Kiểm tra lại !", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txbPassWord.Focus();
                return;
            }
            try
            {
                Program.login = txbLoginName.Text;
                Program.password = txbPassWord.Text;
                if (Program.KetNoi() == 0) return;
                MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OK);
                this.Hide();
                Program.frmMain.Show();
            }
            catch
            {
                MessageBox.Show("Mật Khẩu hoặc Tài Khoản đăng nhập không đúng !!!");
            }
        }

    }
}
