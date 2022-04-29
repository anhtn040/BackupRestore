
using System;
using System.Windows.Forms;

namespace Backup_Restore
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar = new DevExpress.XtraBars.Bar();
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.chkPhucHoi = new DevExpress.XtraBars.BarCheckItem();
            this.btnTaoDevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.dataSet = new Backup_Restore.DataSet();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.dBNAMEToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txbNameDatabase = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txbListBackup = new System.Windows.Forms.ToolStripTextBox();
            this.databasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getlistbkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkSaoluu = new System.Windows.Forms.CheckBox();
            this.pnCheckLoaiRestore = new System.Windows.Forms.Panel();
            this.dateRestore = new DevExpress.XtraEditors.DateEdit();
            this.timeRestore = new DevExpress.XtraEditors.TimeEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.databasesTableAdapter = new Backup_Restore.DataSetTableAdapters.DatabasesTableAdapter();
            this.get_list_bkTableAdapter = new Backup_Restore.DataSetTableAdapters.Get_list_bkTableAdapter();
            this.tableAdapterManager = new Backup_Restore.DataSetTableAdapters.TableAdapterManager();
            this.GetListBkGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new Backup_Restore.DataSet();
            this.DatabasesGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getlistbkBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnCheckLoaiRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRestore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetListBkGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabasesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSaoLuu,
            this.btnPhucHoi,
            this.barButtonItem3,
            this.chkPhucHoi,
            this.btnTaoDevice,
            this.btnXoa,
            this.btn_Thoat});
            this.barManager1.MainMenu = this.bar;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar
            // 
            this.bar.BarName = "Main menu";
            this.bar.DockCol = 0;
            this.bar.DockRow = 0;
            this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaoLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.chkPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaoDevice),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa)});
            this.bar.OptionsBar.MultiLine = true;
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.Text = "Main menu";
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao lưu";
            this.btnSaoLuu.Id = 0;
            this.btnSaoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.Image")));
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 1;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // chkPhucHoi
            // 
            this.chkPhucHoi.Caption = "Tham số phục hồi theo thời gian";
            this.chkPhucHoi.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.chkPhucHoi.Id = 3;
            this.chkPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chkPhucHoi.ImageOptions.Image")));
            this.chkPhucHoi.Name = "chkPhucHoi";
            this.chkPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.chkPhucHoi.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkPhucHoi_CheckedChanged);
            // 
            // btnTaoDevice
            // 
            this.btnTaoDevice.Caption = "Tạo device sao lưu";
            this.btnTaoDevice.Id = 4;
            this.btnTaoDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoDevice.ImageOptions.Image")));
            this.btnTaoDevice.Name = "btnTaoDevice";
            this.btnTaoDevice.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTaoDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoDevice_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 5;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1114, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 512);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1114, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 451);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1114, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 451);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Caption = "Thoát";
            this.btn_Thoat.Id = 6;
            this.btn_Thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.ImageOptions.Image")));
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "database_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "database_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBNAMEToolStripLabel,
            this.txbNameDatabase,
            this.toolStripLabel1,
            this.txbListBackup});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 61);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1114, 25);
            this.fillToolStrip.TabIndex = 37;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillToolStrip_ItemClicked);
            // 
            // dBNAMEToolStripLabel
            // 
            this.dBNAMEToolStripLabel.Name = "dBNAMEToolStripLabel";
            this.dBNAMEToolStripLabel.Size = new System.Drawing.Size(82, 22);
            this.dBNAMEToolStripLabel.Text = "Tên Database :";
            // 
            // txbNameDatabase
            // 
            this.txbNameDatabase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbNameDatabase.Name = "txbNameDatabase";
            this.txbNameDatabase.ReadOnly = true;
            this.txbNameDatabase.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabel1.Text = "Thứ tự bản sao lưu :";
            // 
            // txbListBackup
            // 
            this.txbListBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbListBackup.Name = "txbListBackup";
            this.txbListBackup.ReadOnly = true;
            this.txbListBackup.Size = new System.Drawing.Size(100, 25);
            // 
            // databasesBindingSource
            // 
            this.databasesBindingSource.DataMember = "Databases";
            this.databasesBindingSource.DataSource = this.dataSet;
            // 
            // getlistbkBindingSource
            // 
            this.getlistbkBindingSource.DataMember = "Get_list_bk";
            this.getlistbkBindingSource.DataSource = this.dataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkSaoluu);
            this.panel1.Location = new System.Drawing.Point(406, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 51);
            this.panel1.TabIndex = 40;
            // 
            // checkSaoluu
            // 
            this.checkSaoluu.AutoSize = true;
            this.checkSaoluu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSaoluu.Location = new System.Drawing.Point(99, 14);
            this.checkSaoluu.Name = "checkSaoluu";
            this.checkSaoluu.Size = new System.Drawing.Size(522, 25);
            this.checkSaoluu.TabIndex = 0;
            this.checkSaoluu.Text = "Xóa tất cả các bản sao lưu cũ trong File trước khi sao lưu bản mới";
            this.checkSaoluu.UseVisualStyleBackColor = true;
            // 
            // pnCheckLoaiRestore
            // 
            this.pnCheckLoaiRestore.Controls.Add(this.dateRestore);
            this.pnCheckLoaiRestore.Controls.Add(this.timeRestore);
            this.pnCheckLoaiRestore.Controls.Add(this.label1);
            this.pnCheckLoaiRestore.Controls.Add(this.textBox1);
            this.pnCheckLoaiRestore.ForeColor = System.Drawing.Color.Black;
            this.pnCheckLoaiRestore.Location = new System.Drawing.Point(406, 364);
            this.pnCheckLoaiRestore.Name = "pnCheckLoaiRestore";
            this.pnCheckLoaiRestore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnCheckLoaiRestore.Size = new System.Drawing.Size(688, 128);
            this.pnCheckLoaiRestore.TabIndex = 41;
            // 
            // dateRestore
            // 
            this.dateRestore.EditValue = null;
            this.dateRestore.Location = new System.Drawing.Point(298, 19);
            this.dateRestore.MenuManager = this.barManager1;
            this.dateRestore.Name = "dateRestore";
            this.dateRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRestore.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRestore.Size = new System.Drawing.Size(128, 20);
            this.dateRestore.TabIndex = 4;
            // 
            // timeRestore
            // 
            this.timeRestore.EditValue = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            this.timeRestore.Location = new System.Drawing.Point(474, 18);
            this.timeRestore.MenuManager = this.barManager1;
            this.timeRestore.Name = "timeRestore";
            this.timeRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeRestore.Size = new System.Drawing.Size(130, 20);
            this.timeRestore.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày giờ để phục hồi tại thời điểm đó:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(682, 58);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Hướng Dẫn: Ngày giờ ta nhập vào là thời điểm ta muốn phục hồi cơ sở dữ liệu về đó" +
    ". Thời điểm này phải sau thời điểm của bản sao lưu mà ta đã chọn trên lưới và tr" +
    "ước thời điểm hiện tại ít nhất 1 phút.\n";
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // get_list_bkTableAdapter
            // 
            this.get_list_bkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Backup_Restore.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // GetListBkGridView
            // 
            this.GetListBkGridView.AllowUserToAddRows = false;
            this.GetListBkGridView.AllowUserToDeleteRows = false;
            this.GetListBkGridView.AutoGenerateColumns = false;
            this.GetListBkGridView.BackgroundColor = System.Drawing.Color.White;
            this.GetListBkGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GetListBkGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.GetListBkGridView.DataSource = this.getlistbkBindingSource;
            this.GetListBkGridView.Location = new System.Drawing.Point(403, 89);
            this.GetListBkGridView.Name = "GetListBkGridView";
            this.GetListBkGridView.ReadOnly = true;
            this.GetListBkGridView.Size = new System.Drawing.Size(691, 220);
            this.GetListBkGridView.TabIndex = 49;
            this.GetListBkGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.get_list_bkGridControl_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn3.HeaderText = "Bản sao lưu thứ #";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Diễn giải";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "backup_start_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày sao lưu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "user_name";
            this.dataGridViewTextBoxColumn6.HeaderText = "User sao lưu";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // backupstartdateDataGridViewTextBoxColumn
            // 
            this.backupstartdateDataGridViewTextBoxColumn.DataPropertyName = "backup_start_date";
            this.backupstartdateDataGridViewTextBoxColumn.HeaderText = "backup_start_date";
            this.backupstartdateDataGridViewTextBoxColumn.Name = "backupstartdateDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "user_name";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatabasesGridView
            // 
            this.DatabasesGridView.AllowUserToAddRows = false;
            this.DatabasesGridView.AllowUserToDeleteRows = false;
            this.DatabasesGridView.AutoGenerateColumns = false;
            this.DatabasesGridView.BackgroundColor = System.Drawing.Color.White;
            this.DatabasesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabasesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.DatabasesGridView.DataSource = this.databasesBindingSource;
            this.DatabasesGridView.Location = new System.Drawing.Point(0, 89);
            this.DatabasesGridView.Name = "DatabasesGridView";
            this.DatabasesGridView.ReadOnly = true;
            this.DatabasesGridView.Size = new System.Drawing.Size(397, 403);
            this.DatabasesGridView.TabIndex = 54;
            this.DatabasesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatabasesGridView_CellClick);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Cơ Sở Dữ Liệu";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1114, 532);
            this.Controls.Add(this.DatabasesGridView);
            this.Controls.Add(this.GetListBkGridView);
            this.Controls.Add(this.pnCheckLoaiRestore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormMain";
            this.Text = "Sao lưu -  Phục hồi cơ sở dữ liệu trong SQL Server";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getlistbkBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnCheckLoaiRestore.ResumeLayout(false);
            this.pnCheckLoaiRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRestore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetListBkGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabasesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lbl_PhienBan_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txt_PhienBan_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DataGridView_device_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarCheckItem chkPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnTaoDevice;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataSet dataSet;
        private ToolStrip fillToolStrip;
        private ToolStripLabel dBNAMEToolStripLabel;
        private ToolStripTextBox txbNameDatabase;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txbListBackup;
        private Panel pnCheckLoaiRestore;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private CheckBox checkSaoluu;
        private DevExpress.XtraEditors.DateEdit dateRestore;
        private DevExpress.XtraEditors.TimeEdit timeRestore;
        private BindingSource databasesBindingSource;
        private DataSetTableAdapters.DatabasesTableAdapter databasesTableAdapter;
        private BindingSource getlistbkBindingSource;
        private DataSetTableAdapters.Get_list_bkTableAdapter get_list_bkTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataGridView GetListBkGridView;
        private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn backupstartdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataSet dataSet1;
        private DataGridView DatabasesGridView;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    }
}