﻿namespace QLTV.GUI
{
    partial class frmCTMuonSach
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
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.item_Them = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Sua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Xuat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.dgv_Them = new System.Windows.Forms.DataGridView();
            this.iDCTPhieuMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhieuMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCuonSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPHIEUMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbb_TenTacGia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_CuonSach = new System.Windows.Forms.ListBox();
            this.cbb_IDCuonSach = new System.Windows.Forms.TextBox();
            this.cbb_IDPhieuMuon = new System.Windows.Forms.TextBox();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pic_Ss = new System.Windows.Forms.PictureBox();
            this.pic_Warning = new System.Windows.Forms.PictureBox();
            this.tb_IDCTPhieuMuon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cUONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_PHIEUMUONTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CT_PHIEUMUONTableAdapter();
            this.pHIEUMUONTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.PHIEUMUONTableAdapter();
            this.cUONSACHTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CUONSACHTableAdapter();
            this.btn_ThemSach = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.item_Them.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUMUONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.item_Them);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.item_Them});
            this.navigationPane1.RegularSize = new System.Drawing.Size(913, 512);
            this.navigationPane1.SelectedPage = this.item_Them;
            this.navigationPane1.Size = new System.Drawing.Size(913, 512);
            this.navigationPane1.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Regular;
            this.navigationPane1.TabIndex = 3;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // item_Them
            // 
            this.item_Them.Caption = "Thêm chi tiết phiếu mượn";
            this.item_Them.Controls.Add(this.groupControl2);
            this.item_Them.Controls.Add(this.groupControl1);
            this.item_Them.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_plus_40;
            this.item_Them.Margin = new System.Windows.Forms.Padding(2);
            this.item_Them.Name = "item_Them";
            this.item_Them.Size = new System.Drawing.Size(839, 452);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.bindingNavigator1);
            this.groupControl2.Controls.Add(this.dgv_Them);
            this.groupControl2.Location = new System.Drawing.Point(383, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(456, 451);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu chi tiết phiếu mượn";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Luu,
            this.toolStripSeparator4,
            this.btn_Sua,
            this.toolStripSeparator1,
            this.btn_Xoa,
            this.toolStripSeparator9,
            this.btn_Xuat,
            this.toolStripSeparator2,
            this.btn_Reset,
            this.toolStripSeparator3,
            this.btn_Exit});
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 31);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(452, 31);
            this.bindingNavigator1.TabIndex = 14;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Luu.ForeColor = System.Drawing.Color.Red;
            this.btn_Luu.Image = global::QLTV.Properties.Resources.diskette;
            this.btn_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(60, 28);
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_Sua
            // 
            this.btn_Sua.ForeColor = System.Drawing.Color.Red;
            this.btn_Sua.Image = global::QLTV.Properties.Resources.icons8_pencil_80;
            this.btn_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 28);
            this.btn_Sua.Text = "Sửa thông tin";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Image = global::QLTV.Properties.Resources.icons8_cancel_80;
            this.btn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(60, 28);
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.ForeColor = System.Drawing.Color.Red;
            this.btn_Xuat.Image = global::QLTV.Properties.Resources.icons8_export_csv_40;
            this.btn_Xuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(94, 28);
            this.btn_Xuat.Text = "Xuất CSV";
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_Reset
            // 
            this.btn_Reset.ForeColor = System.Drawing.Color.Red;
            this.btn_Reset.Image = global::QLTV.Properties.Resources.icons8_available_updates_40;
            this.btn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(115, 28);
            this.btn_Reset.Text = "Reset dữ liệu";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Image = global::QLTV.Properties.Resources.icons8_shutdown_80;
            this.btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(72, 28);
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // dgv_Them
            // 
            this.dgv_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Them.AutoGenerateColumns = false;
            this.dgv_Them.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Them.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCTPhieuMuonDataGridViewTextBoxColumn,
            this.iDPhieuMuonDataGridViewTextBoxColumn,
            this.iDCuonSachDataGridViewTextBoxColumn});
            this.dgv_Them.DataSource = this.cTPHIEUMUONBindingSource;
            this.dgv_Them.Location = new System.Drawing.Point(4, 63);
            this.dgv_Them.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Them.Name = "dgv_Them";
            this.dgv_Them.RowTemplate.Height = 28;
            this.dgv_Them.Size = new System.Drawing.Size(448, 384);
            this.dgv_Them.TabIndex = 2;
            this.dgv_Them.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Them_CellClick);
            this.dgv_Them.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Them_CellValueChanged);
            // 
            // iDCTPhieuMuonDataGridViewTextBoxColumn
            // 
            this.iDCTPhieuMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDCTPhieuMuonDataGridViewTextBoxColumn.DataPropertyName = "IDCTPhieuMuon";
            this.iDCTPhieuMuonDataGridViewTextBoxColumn.HeaderText = "ID chi tiết phiếu mượn";
            this.iDCTPhieuMuonDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.iDCTPhieuMuonDataGridViewTextBoxColumn.Name = "iDCTPhieuMuonDataGridViewTextBoxColumn";
            this.iDCTPhieuMuonDataGridViewTextBoxColumn.Width = 168;
            // 
            // iDPhieuMuonDataGridViewTextBoxColumn
            // 
            this.iDPhieuMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDPhieuMuonDataGridViewTextBoxColumn.DataPropertyName = "IDPhieuMuon";
            this.iDPhieuMuonDataGridViewTextBoxColumn.HeaderText = "ID phiếu mượn";
            this.iDPhieuMuonDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.iDPhieuMuonDataGridViewTextBoxColumn.Name = "iDPhieuMuonDataGridViewTextBoxColumn";
            this.iDPhieuMuonDataGridViewTextBoxColumn.Width = 153;
            // 
            // iDCuonSachDataGridViewTextBoxColumn
            // 
            this.iDCuonSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDCuonSachDataGridViewTextBoxColumn.DataPropertyName = "IDCuonSach";
            this.iDCuonSachDataGridViewTextBoxColumn.HeaderText = "ID cuốn sách";
            this.iDCuonSachDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.iDCuonSachDataGridViewTextBoxColumn.Name = "iDCuonSachDataGridViewTextBoxColumn";
            this.iDCuonSachDataGridViewTextBoxColumn.Width = 137;
            // 
            // cTPHIEUMUONBindingSource
            // 
            this.cTPHIEUMUONBindingSource.DataMember = "CT_PHIEUMUON";
            this.cTPHIEUMUONBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_ThemSach);
            this.groupControl1.Controls.Add(this.cbb_TenTacGia);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.lv_CuonSach);
            this.groupControl1.Controls.Add(this.cbb_IDCuonSach);
            this.groupControl1.Controls.Add(this.cbb_IDPhieuMuon);
            this.groupControl1.Controls.Add(this.btn_Them);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.pic_Ss);
            this.groupControl1.Controls.Add(this.pic_Warning);
            this.groupControl1.Controls.Add(this.tb_IDCTPhieuMuon);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(379, 451);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin chi tiết phiếu mượn";
            // 
            // cbb_TenTacGia
            // 
            this.cbb_TenTacGia.FormattingEnabled = true;
            this.cbb_TenTacGia.Location = new System.Drawing.Point(225, 195);
            this.cbb_TenTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_TenTacGia.Name = "cbb_TenTacGia";
            this.cbb_TenTacGia.Size = new System.Drawing.Size(117, 32);
            this.cbb_TenTacGia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(4, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tên tác giả:";
            // 
            // lv_CuonSach
            // 
            this.lv_CuonSach.FormattingEnabled = true;
            this.lv_CuonSach.ItemHeight = 24;
            this.lv_CuonSach.Location = new System.Drawing.Point(8, 260);
            this.lv_CuonSach.Margin = new System.Windows.Forms.Padding(2);
            this.lv_CuonSach.Name = "lv_CuonSach";
            this.lv_CuonSach.Size = new System.Drawing.Size(335, 100);
            this.lv_CuonSach.TabIndex = 4;
            this.lv_CuonSach.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_CuonSach_MouseDoubleClick);
            // 
            // cbb_IDCuonSach
            // 
            this.cbb_IDCuonSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_IDCuonSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbb_IDCuonSach.Location = new System.Drawing.Point(225, 153);
            this.cbb_IDCuonSach.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_IDCuonSach.Name = "cbb_IDCuonSach";
            this.cbb_IDCuonSach.Size = new System.Drawing.Size(118, 32);
            this.cbb_IDCuonSach.TabIndex = 3;
            this.cbb_IDCuonSach.TextChanged += new System.EventHandler(this.cbb_IDCuonSach_TextChanged);
            // 
            // cbb_IDPhieuMuon
            // 
            this.cbb_IDPhieuMuon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_IDPhieuMuon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbb_IDPhieuMuon.Location = new System.Drawing.Point(225, 112);
            this.cbb_IDPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_IDPhieuMuon.Name = "cbb_IDPhieuMuon";
            this.cbb_IDPhieuMuon.Size = new System.Drawing.Size(118, 32);
            this.cbb_IDPhieuMuon.TabIndex = 2;
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.btn_Them.Location = new System.Drawing.Point(127, 396);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(105, 51);
            this.btn_Them.TabIndex = 30;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(222, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "label5";
            // 
            // pic_Ss
            // 
            this.pic_Ss.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.pic_Ss.Location = new System.Drawing.Point(345, 53);
            this.pic_Ss.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Ss.Name = "pic_Ss";
            this.pic_Ss.Size = new System.Drawing.Size(29, 27);
            this.pic_Ss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Ss.TabIndex = 17;
            this.pic_Ss.TabStop = false;
            // 
            // pic_Warning
            // 
            this.pic_Warning.Image = global::QLTV.Properties.Resources.icons8_cancel_40;
            this.pic_Warning.Location = new System.Drawing.Point(345, 53);
            this.pic_Warning.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Warning.Name = "pic_Warning";
            this.pic_Warning.Size = new System.Drawing.Size(29, 27);
            this.pic_Warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Warning.TabIndex = 16;
            this.pic_Warning.TabStop = false;
            // 
            // tb_IDCTPhieuMuon
            // 
            this.tb_IDCTPhieuMuon.Location = new System.Drawing.Point(225, 53);
            this.tb_IDCTPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.tb_IDCTPhieuMuon.MaxLength = 3;
            this.tb_IDCTPhieuMuon.Name = "tb_IDCTPhieuMuon";
            this.tb_IDCTPhieuMuon.Size = new System.Drawing.Size(118, 32);
            this.tb_IDCTPhieuMuon.TabIndex = 1;
            this.tb_IDCTPhieuMuon.TextChanged += new System.EventHandler(this.tb_IDCTPhieuMuon_TextChanged);
            this.tb_IDCTPhieuMuon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên cuốn sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID phiếu mượn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID chi tiết phiếu mượn:";
            // 
            // cUONSACHBindingSource
            // 
            this.cUONSACHBindingSource.DataMember = "CUONSACH";
            this.cUONSACHBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // pHIEUMUONBindingSource
            // 
            this.pHIEUMUONBindingSource.DataMember = "PHIEUMUON";
            this.pHIEUMUONBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // cT_PHIEUMUONTableAdapter
            // 
            this.cT_PHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // pHIEUMUONTableAdapter
            // 
            this.pHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // cUONSACHTableAdapter
            // 
            this.cUONSACHTableAdapter.ClearBeforeFill = true;
            // 
            // btn_ThemSach
            // 
            this.btn_ThemSach.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_ThemSach.Appearance.Options.UseFont = true;
            this.btn_ThemSach.Location = new System.Drawing.Point(225, 231);
            this.btn_ThemSach.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThemSach.Name = "btn_ThemSach";
            this.btn_ThemSach.Size = new System.Drawing.Size(105, 25);
            this.btn_ThemSach.TabIndex = 32;
            this.btn_ThemSach.Text = "Thêm sách";
            this.btn_ThemSach.Click += new System.EventHandler(this.btn_ThemSach_Click);
            // 
            // frmCTMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 512);
            this.Controls.Add(this.navigationPane1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCTMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết mượn sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCTMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.item_Them.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUMUONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage item_Them;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgv_Them;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource cTPHIEUMUONBindingSource;
        private QuanLyThuVienDataSetTableAdapters.CT_PHIEUMUONTableAdapter cT_PHIEUMUONTableAdapter;
        private System.Windows.Forms.TextBox tb_IDCTPhieuMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pHIEUMUONBindingSource;
        private QuanLyThuVienDataSetTableAdapters.PHIEUMUONTableAdapter pHIEUMUONTableAdapter;
        private System.Windows.Forms.BindingSource cUONSACHBindingSource;
        private QuanLyThuVienDataSetTableAdapters.CUONSACHTableAdapter cUONSACHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCTPhieuMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCuonSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pic_Ss;
        private System.Windows.Forms.PictureBox pic_Warning;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btn_Luu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_Sua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Reset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Exit;
        private System.Windows.Forms.TextBox cbb_IDPhieuMuon;
        private System.Windows.Forms.TextBox cbb_IDCuonSach;
        private System.Windows.Forms.ListBox lv_CuonSach;
        private System.Windows.Forms.ComboBox cbb_TenTacGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btn_Xuat;
        private DevExpress.XtraEditors.SimpleButton btn_ThemSach;
    }
}