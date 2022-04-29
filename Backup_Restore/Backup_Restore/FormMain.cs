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
using DevExpress.XtraBars;

namespace Backup_Restore
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        

        int listbackup = 0;
        String NameDevice = "";
        int listbackuplastest = 0;


        public FormMain()
        {
            InitializeComponent();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.databasesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.databasesTableAdapter.Fill(this.dataSet.Databases);
            // TODO: This line of code loads data into the 'qLVT1DataSet.databases' table. You can move, or remove it, as needed.
            databasesBindingSource.Position = 0;
            txbNameDatabase.Text = ((DataRowView)databasesBindingSource[databasesBindingSource.Position])["name"].ToString();
            LoadListBackUp();
            //DatabasesGridView_CellClick(sender, e);
            pnCheckLoaiRestore.Hide();
        }

        private void LoadListBackUp()
        {
            if (txbNameDatabase.Text.Trim() == "") return;
            try
            {
                this.get_list_bkTableAdapter.Connection.ConnectionString = Program.connstr;
                this.get_list_bkTableAdapter.Fill(this.dataSet.Get_list_bk, txbNameDatabase.Text.Trim());
                if (getlistbkBindingSource.Count == 0)
                {
                    listbackup = 0;
                }
                else
                {
                    listbackup = int.Parse(((DataRowView)getlistbkBindingSource[0])["position"].ToString());
                }
                txbListBackup.Text = listbackup.ToString();
                CheckCountDevice();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + "  .Sai ở hàm load cac ban sao luu");
            }
        }



        private void CheckCountDevice()
        {
           
            String sql = "SELECT COUNT(name) FROM sys.backup_devices WHERE name = N'DEV_" + txbNameDatabase.Text.Trim() + "'";
            Program.myReader = Program.ExecuteReader(sql);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            //có decive thì ẩn nút device
            if(Program.myReader.GetInt32(0)>0)
            {
                if(listbackup == 0)
                {
                    btnPhucHoi.Enabled = chkPhucHoi.Enabled = false;
                }
                else
                {
                    btnPhucHoi.Enabled = chkPhucHoi.Enabled = true;
                }
                btnSaoLuu.Enabled = true;
                btnTaoDevice.Enabled = false;

                NameDevice = "DEV_" + txbNameDatabase.Text.Trim();
            }
            //chưa có thì tạo bản mới
            else
            {
                btnPhucHoi.Enabled = btnSaoLuu.Enabled = chkPhucHoi.Enabled = false;
                btnTaoDevice.Enabled = true;
            }
            Program.myReader.Close();
        }


        public int CreateDevice(String tenDatabase)
        {
            String CreateDevice = "EXEC sp_addumpdevice 'disk' , 'DEV_" + tenDatabase.Trim() + "' , '" + Program.URLDEV + tenDatabase.Trim() + ".bak'";
            int KT = Program.ExecSqlNonQuery(CreateDevice, Program.connstr, "");
            
            if(KT != 0)
            {
                MessageBox.Show("Xảy ra lỗi khi tạo mới device");
                return 0;
            }
            else
            {
                return 1;
            }
        }



        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                this.get_list_bkTableAdapter.Fill(this.dataSet.Get_list_bk, txbNameDatabase.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void chkPhucHoi_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chkPhucHoi.Checked == true)
            {
                pnCheckLoaiRestore.Show();
                
                dateRestore.DateTime = DateTime.Now;
                timeRestore.Time = DateTime.Now;
            }
            else
            {
                this.pnCheckLoaiRestore.Hide();
                
            }
        }

        private void btnTaoDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int t = CreateDevice(txbNameDatabase.Text.Trim());
            if (t == 0)
            {
                MessageBox.Show("Xảy ra lỗi khi sao lưu.");
                return;
            }
            else
            {
                MessageBox.Show("Đã tạo mới device thành công.");
            }
            btnSaoLuu.Enabled = true;
            btnTaoDevice.Enabled = false;
        }

        private void DatabasesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (databasesBindingSource.Position == -1 || databasesBindingSource.Count == 0 || databasesBindingSource.DataSource == null)
                {
                    txbNameDatabase.Text = "";
                }
                else
                {
                    txbNameDatabase.Text = ((DataRowView)databasesBindingSource[databasesBindingSource.Position])["name"].ToString();

                }
                LoadListBackUp();
                txbNameDatabase.Text = ((DataRowView)databasesBindingSource[databasesBindingSource.Position])["name"].ToString();
                CheckCountDevice();
                NameDevice = "DEV_" + txbNameDatabase.Text.Trim();
                listbackuplastest = databasesBindingSource.Count;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void get_list_bkGridControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            listbackup = int.Parse(((DataRowView)getlistbkBindingSource[getlistbkBindingSource.Position])["position"].ToString());
            txbListBackup.Text = listbackup.ToString();
        }


        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NameDevice.Trim() == "" || txbNameDatabase.Text.Trim() == "")
            {
                return;
            }
            else
            {
                if(checkSaoluu.Checked == true)
                {
                    DialogResult tn1 = MessageBox.Show("Bạn có muốn sao lưu ghì đè trên file cũ ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(tn1 == DialogResult.Yes)
                    {
                        String xoadevice = "EXEC sp_dropdevice 'DEV_" + txbNameDatabase.Text.Trim() + "', 'delfile'";
                        int KT = Program.ExecSqlNonQuery(xoadevice, Program.connstr, "");
                        if(KT != 0)
                        {
                            MessageBox.Show("Lỗi khi xóa device sao lưu");
                            return;
                        }
                        int t = CreateDevice(txbNameDatabase.Text.Trim());
                        if (t == 0)
                        {
                            MessageBox.Show("Lỗi khi sao lưu");
                            return;
                        }
                        NameDevice = "DEV_" + txbNameDatabase.Text.Trim();
                        String a = "BACKUP DATABASE " + txbNameDatabase.Text.Trim() + " TO " + NameDevice.Trim() + " WITH INIT";
                        KT = Program.ExecSqlNonQuery(a, Program.connstr, "");
                        if (KT != 0)
                        {
                            MessageBox.Show("Lỗi khi sao lưu");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Sao lưu device thành công.");
                            LoadListBackUp();
                            checkSaoluu.Enabled = true;
                            return;
                        }

                    }
                }
                else
                {
                    DialogResult tn2 = MessageBox.Show("Bạn muốn sao lưu device? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(tn2 == DialogResult.Yes)
                    {
                        String a = "BACKUP DATABASE " + txbNameDatabase.Text.Trim() + " TO " +  NameDevice.Trim();
                        int KT = Program.ExecSqlNonQuery(a, Program.connstr, "");
                        if (KT != 0)
                        {
                            MessageBox.Show("Lỗi khi sao lưu");
                            return;

                        }
                        else
                        {
                            MessageBox.Show("Sao lưu thành công");
                            LoadListBackUp();
                            return;
                        }
                    }
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }

            //ngắt kết nối tới cả server
            String strRestore = " ALTER DATABASE " + txbNameDatabase.Text.Trim() + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " + " USE tempdb ";


            if (chkPhucHoi.Checked == false)
            {
                strRestore += "RESTORE DATABASE " + txbNameDatabase.Text.Trim()
                    + " From " + NameDevice + " WITH FILE = " + listbackup + ", REPLACE "
                    + " ALTER DATABASE " + txbNameDatabase.Text.Trim() + " SET MULTI_USER ";

                int KT = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Phục hồi CSDL xảy ra lỗi!");
                if(KT != 0)
                {
                    MessageBox.Show("Xảy ra lỗi khi Restore");
                    return ;
                }
                else
                {
                    MessageBox.Show("Restore về bản thứ " + listbackup + " thành công !");
                    return ;
                }
            }
            else
            //sau thời điểm bản full chọn trên lưới và trước thời điểm hiện tại 1'
            {
                DateTime TgBanBK = (DateTime)((DataRowView)getlistbkBindingSource[getlistbkBindingSource.Position])["backup_start_date"];

                // thời gian được chọn restore
                String TgNgDungChon = dateRestore.DateTime.Day + "/" + dateRestore.DateTime.Month + "/"+ dateRestore.DateTime.Year + " " 
                    + timeRestore.Time.Hour + ":" + (timeRestore.Time.Minute ) + ":" + timeRestore.Time.Second;

                // trường hợp h:m:s nhưng phần còn lại m dương
                DateTime ThoigianTMDK;
                ThoigianTMDK = DateTime.Parse(TgNgDungChon);

                if ((dateRestore.DateTime.Date < TgBanBK.Date) || (dateRestore.DateTime.Date == TgBanBK.Date && ThoigianTMDK.TimeOfDay.Ticks < TgBanBK.TimeOfDay.Ticks))
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải sau thời điểm bản sao lưu đã được chọn!", "", MessageBoxButtons.OK);
                    return;
                }
                if (ThoigianTMDK > DateTime.Now)
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại!", "", MessageBoxButtons.OK);
                    return;
                }
                if(MessageBox.Show("Bạn muốn phục hồi database " + txbNameDatabase.Text + " về ngày " + ThoigianTMDK + " ? ", "" , MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        strRestore = " ALTER DATABASE " + txbNameDatabase.Text.Trim() + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE "
                            + " BACKUP LOG " + txbNameDatabase.Text.Trim() + " TO DISK ='" + Program.URL +  txbNameDatabase.Text.Trim() +  ".trn' WITH INIT"
                            + " USE tempdb RESTORE DATABASE " + txbNameDatabase.Text.Trim() + " FROM DEV_" + txbNameDatabase.Text.Trim()+ " WITH FILE = " + listbackup + ", NORECOVERY,REPLACE"
                            + " USE tempdb SET DATEFORMAT DMY RESTORE DATABASE " + txbNameDatabase.Text.Trim() + " FROM DISK = '" + Program.URL + txbNameDatabase.Text.Trim() + ".trn' WITH STOPAT='" + TgNgDungChon + "',RECOVERY "
                            + " ALTER DATABASE " + txbNameDatabase.Text.Trim() + " SET MULTI_USER ";
                        //dong lai database(che do mot nguoi dung)
                        //backup log
                        //restore ban full moi nhat
                        //restore ve thoi diem truoc loi
                        //chuyen lại che do bt cho database

                        int KT = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi CSDL !");
                        if (KT == 0)
                        {
                            MessageBox.Show("Phục hồi CSDL thành công !", "", MessageBoxButtons.OK);
                            return;
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Restore lỗi:\n" + ex, "", MessageBoxButtons.OK);
                       
                    }
                }

            }

             
        }


       
    }
}