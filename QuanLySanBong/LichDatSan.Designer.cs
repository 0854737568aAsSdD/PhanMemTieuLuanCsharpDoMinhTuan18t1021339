namespace QuanLySanBong
{
    partial class LichDatSan
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
            this.monthCalendarAdv1 = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.LvLichDatSan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblHienThi = new DevComponents.DotNetBar.LabelX();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMaPhieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaSan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtKhachHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtpNgayDat = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblMaPhieu = new DevComponents.DotNetBar.LabelX();
            this.lblMaSan = new DevComponents.DotNetBar.LabelX();
            this.lblKhachHang = new DevComponents.DotNetBar.LabelX();
            this.lblNgayDat = new DevComponents.DotNetBar.LabelX();
            this.btnTrungGian = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtTim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTroLai = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDat)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendarAdv1
            // 
            this.monthCalendarAdv1.AutoSize = true;
            // 
            // 
            // 
            this.monthCalendarAdv1.BackgroundStyle.Class = "MonthCalendarAdv";
            this.monthCalendarAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.monthCalendarAdv1.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.monthCalendarAdv1.ContainerControlProcessDialogKey = true;
            this.monthCalendarAdv1.DisplayMonth = new System.DateTime(2021, 12, 1, 0, 0, 0, 0);
            this.monthCalendarAdv1.Location = new System.Drawing.Point(53, 9);
            this.monthCalendarAdv1.Name = "monthCalendarAdv1";
            // 
            // 
            // 
            this.monthCalendarAdv1.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.monthCalendarAdv1.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.monthCalendarAdv1.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.monthCalendarAdv1.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.monthCalendarAdv1.Size = new System.Drawing.Size(170, 131);
            this.monthCalendarAdv1.TabIndex = 4;
            this.monthCalendarAdv1.Text = "monthCalendarAdv1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý lịch đặt sân";
            // 
            // LvLichDatSan
            // 
            this.LvLichDatSan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LvLichDatSan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvLichDatSan.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LvLichDatSan.FullRowSelect = true;
            this.LvLichDatSan.GridLines = true;
            this.LvLichDatSan.HideSelection = false;
            this.LvLichDatSan.Location = new System.Drawing.Point(329, 38);
            this.LvLichDatSan.Name = "LvLichDatSan";
            this.LvLichDatSan.Size = new System.Drawing.Size(470, 382);
            this.LvLichDatSan.TabIndex = 6;
            this.LvLichDatSan.UseCompatibleStateImageBehavior = false;
            this.LvLichDatSan.View = System.Windows.Forms.View.Details;
            this.LvLichDatSan.SelectedIndexChanged += new System.EventHandler(this.LvLichDatSan_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Phiếu Sân";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Sân";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Sân";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Họ Tên Khách Hàng";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày nhận";
            this.columnHeader5.Width = 140;
            // 
            // lblHienThi
            // 
            // 
            // 
            // 
            this.lblHienThi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(498, 11);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(278, 23);
            this.lblHienThi.TabIndex = 7;
            this.lblHienThi.Text = "Danh Sách Khách Nhận Sân";
            // 
            // picUpdate
            // 
            this.picUpdate.Image = global::QuanLySanBong.Properties.Resources.iconupdate;
            this.picUpdate.Location = new System.Drawing.Point(12, 197);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(40, 33);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdate.TabIndex = 12;
            this.picUpdate.TabStop = false;
            this.picUpdate.Click += new System.EventHandler(this.picUpdate_Click);
            // 
            // picDelete
            // 
            this.picDelete.Image = global::QuanLySanBong.Properties.Resources.icondelete;
            this.picDelete.Location = new System.Drawing.Point(12, 249);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(40, 40);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 11;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // picSearch
            // 
            this.picSearch.Image = global::QuanLySanBong.Properties.Resources.iconsearch;
            this.picSearch.Location = new System.Drawing.Point(12, 306);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(40, 41);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 10;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // picAdd
            // 
            this.picAdd.Image = global::QuanLySanBong.Properties.Resources.iconadd;
            this.picAdd.Location = new System.Drawing.Point(12, 146);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(40, 36);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 9;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLySanBong.Properties.Resources.icons8_football2_64;
            this.pictureBox1.Location = new System.Drawing.Point(250, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 64);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtMaPhieu
            // 
            // 
            // 
            // 
            this.txtMaPhieu.Border.Class = "TextBoxBorder";
            this.txtMaPhieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaPhieu.Location = new System.Drawing.Point(161, 162);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.PreventEnterBeep = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(162, 20);
            this.txtMaPhieu.TabIndex = 13;
            // 
            // txtMaSan
            // 
            // 
            // 
            // 
            this.txtMaSan.Border.Class = "TextBoxBorder";
            this.txtMaSan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaSan.Location = new System.Drawing.Point(161, 197);
            this.txtMaSan.Name = "txtMaSan";
            this.txtMaSan.PreventEnterBeep = true;
            this.txtMaSan.Size = new System.Drawing.Size(162, 20);
            this.txtMaSan.TabIndex = 14;
            // 
            // txtKhachHang
            // 
            // 
            // 
            // 
            this.txtKhachHang.Border.Class = "TextBoxBorder";
            this.txtKhachHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKhachHang.Location = new System.Drawing.Point(161, 236);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.PreventEnterBeep = true;
            this.txtKhachHang.Size = new System.Drawing.Size(162, 20);
            this.txtKhachHang.TabIndex = 14;
            // 
            // dtpNgayDat
            // 
            // 
            // 
            // 
            this.dtpNgayDat.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpNgayDat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayDat.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpNgayDat.ButtonDropDown.Visible = true;
            this.dtpNgayDat.IsPopupCalendarOpen = false;
            this.dtpNgayDat.Location = new System.Drawing.Point(161, 279);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpNgayDat.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayDat.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpNgayDat.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpNgayDat.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpNgayDat.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgayDat.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpNgayDat.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpNgayDat.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpNgayDat.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpNgayDat.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayDat.MonthCalendar.DisplayMonth = new System.DateTime(2021, 12, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpNgayDat.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpNgayDat.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgayDat.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpNgayDat.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayDat.MonthCalendar.TodayButtonVisible = true;
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(162, 20);
            this.dtpNgayDat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpNgayDat.TabIndex = 15;
            // 
            // lblMaPhieu
            // 
            // 
            // 
            // 
            this.lblMaPhieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMaPhieu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieu.Location = new System.Drawing.Point(80, 159);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(75, 23);
            this.lblMaPhieu.TabIndex = 16;
            this.lblMaPhieu.Text = "Mã Phiếu : ";
            // 
            // lblMaSan
            // 
            // 
            // 
            // 
            this.lblMaSan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMaSan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSan.Location = new System.Drawing.Point(80, 194);
            this.lblMaSan.Name = "lblMaSan";
            this.lblMaSan.Size = new System.Drawing.Size(75, 23);
            this.lblMaSan.TabIndex = 17;
            this.lblMaSan.Text = "Mã Sân :";
            // 
            // lblKhachHang
            // 
            // 
            // 
            // 
            this.lblKhachHang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblKhachHang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(68, 233);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(87, 23);
            this.lblKhachHang.TabIndex = 19;
            this.lblKhachHang.Text = "Khách Hàng :";
            // 
            // lblNgayDat
            // 
            // 
            // 
            // 
            this.lblNgayDat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNgayDat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDat.Location = new System.Drawing.Point(80, 276);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(75, 23);
            this.lblNgayDat.TabIndex = 20;
            this.lblNgayDat.Text = "Ngày Đặt :";
            // 
            // btnTrungGian
            // 
            this.btnTrungGian.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTrungGian.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTrungGian.Location = new System.Drawing.Point(193, 351);
            this.btnTrungGian.Name = "btnTrungGian";
            this.btnTrungGian.Size = new System.Drawing.Size(88, 33);
            this.btnTrungGian.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTrungGian.TabIndex = 21;
            this.btnTrungGian.Text = "....";
            this.btnTrungGian.Click += new System.EventHandler(this.btnTrungGian_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(80, 316);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 22;
            this.labelX1.Text = "Tìm : ";
            // 
            // txtTim
            // 
            // 
            // 
            // 
            this.txtTim.Border.Class = "TextBoxBorder";
            this.txtTim.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTim.Location = new System.Drawing.Point(161, 318);
            this.txtTim.Name = "txtTim";
            this.txtTim.PreventEnterBeep = true;
            this.txtTim.Size = new System.Drawing.Size(162, 20);
            this.txtTim.TabIndex = 23;
            // 
            // btnTroLai
            // 
            this.btnTroLai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTroLai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTroLai.Location = new System.Drawing.Point(2, 9);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(45, 23);
            this.btnTroLai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTroLai.TabIndex = 24;
            this.btnTroLai.Text = "<-";
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // LichDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnTrungGian);
            this.Controls.Add(this.lblNgayDat);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.lblMaSan);
            this.Controls.Add(this.lblMaPhieu);
            this.Controls.Add(this.dtpNgayDat);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.txtMaSan);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.picUpdate);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.LvLichDatSan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendarAdv1);
            this.Name = "LichDatSan";
            this.Text = "LichDatSan";
            this.Load += new System.EventHandler(this.LichDatSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv monthCalendarAdv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LvLichDatSan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private DevComponents.DotNetBar.LabelX lblHienThi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPhieu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaSan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKhachHang;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpNgayDat;
        private DevComponents.DotNetBar.LabelX lblMaPhieu;
        private DevComponents.DotNetBar.LabelX lblMaSan;
        private DevComponents.DotNetBar.LabelX lblKhachHang;
        private DevComponents.DotNetBar.LabelX lblNgayDat;
        private DevComponents.DotNetBar.ButtonX btnTrungGian;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTim;
        private DevComponents.DotNetBar.ButtonX btnTroLai;
    }
}