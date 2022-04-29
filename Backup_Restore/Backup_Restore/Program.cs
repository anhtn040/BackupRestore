using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Backup_Restore
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String login = "";
        public static String password = "";

        public static String URL = "E:/Nam3_HK2/ThucTapCoSo/BACKUP_DEVICE/TIME/";
        public static String URLDEV = "E:/Nam3_HK2/ThucTapCoSo/BACKUP_DEVICE/DEV/";
        public static String database = "QLVT1";
        public static FormDangNhap frmLogin;
        public static FormMain frmMain;

        public static int KetNoi() //null thì lỗi, không null thì chạy
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
            {
                Program.conn.Close();
            }

            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                                Program.database + ";User ID=" + Program.login + ";Password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Program.connstr);
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại Username và Password.\n" + ex.Message, "Lỗi kết nối!", MessageBoxButtons.OK);
                return 0;
            }
        
            /// <summary>
            /// The main entry point for the application.
        }

        public static SqlDataReader ExecuteReader(String strL)
        {
            SqlDataReader myreader;
            SqlCommand cmd = new SqlCommand(strL, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 600; // Đợi lệnh chạy. đơn vị: giây.
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = cmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public static int ExecSqlNonQuery(string lenh, string connect, string error)
        {
            conn = new SqlConnection(connect);
            SqlCommand sqlcmd = new SqlCommand(lenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                int loi = sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Lỗi khi chuyển đổi kiểu dữ liệu varchar sang int"))
                {
                    MessageBox.Show("Định dạng lại các cột kiểu char qua int");
                }
                else
                {
                    MessageBox.Show(error + "\n" + ex.Message);
                }
                conn.Close();
                return ex.State;//trạng thái lỗi gửi từ SQL server
            }

        }


        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMain = new FormMain();
            frmLogin = new FormDangNhap();
            Application.Run(frmLogin);
        }

        
    }
}
