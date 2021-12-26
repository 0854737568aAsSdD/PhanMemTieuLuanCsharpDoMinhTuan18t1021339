namespace QuanLySanBong
{
    partial class frmSan
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
            this.lvSanBong = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnCapNhat = new DevComponents.DotNetBar.ButtonX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.txtMaSan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenSan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtKichThuoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblMaSan = new DevComponents.DotNetBar.LabelX();
            this.lblTenSan = new DevComponents.DotNetBar.LabelX();
            this.lblKichThuoc = new DevComponents.DotNetBar.LabelX();
            this.lblGiaThue = new DevComponents.DotNetBar.LabelX();
            this.txtGiaThue = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTrungGian = new DevComponents.DotNetBar.ButtonX();
            this.lblTim = new DevComponents.DotNetBar.LabelX();
            this.txtTim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTroLai = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvSanBong
            // 
            // 
            // 
            // 
            this.lvSanBong.Border.Class = "ListViewBorder";
            this.lvSanBong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvSanBong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSanBong.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvSanBong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSanBong.FullRowSelect = true;
            this.lvSanBong.GridLines = true;
            this.lvSanBong.HideSelection = false;
            this.lvSanBong.Location = new System.Drawing.Point(383, 3);
            this.lvSanBong.Name = "lvSanBong";
            this.lvSanBong.Size = new System.Drawing.Size(351, 374);
            this.lvSanBong.TabIndex = 0;
            this.lvSanBong.UseCompatibleStateImageBehavior = false;
            this.lvSanBong.View = System.Windows.Forms.View.Details;
            this.lvSanBong.SelectedIndexChanged += new System.EventHandler(this.lvSanBong_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sân Bóng";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sân Bóng";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kích thước";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá Thuê";
            this.columnHeader4.Width = 100;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(31, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 39);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm Sân Bóng";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(31, 48);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 40);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa Sân Bóng";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCapNhat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(31, 91);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(83, 34);
            this.btnCapNhat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập Nhật Sân Bóng";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(31, 131);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(83, 34);
            this.btnTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm Kiếm Sân Bóng";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaSan
            // 
            // 
            // 
            // 
            this.txtMaSan.Border.Class = "TextBoxBorder";
            this.txtMaSan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaSan.Location = new System.Drawing.Point(239, 12);
            this.txtMaSan.Name = "txtMaSan";
            this.txtMaSan.PreventEnterBeep = true;
            this.txtMaSan.Size = new System.Drawing.Size(124, 20);
            this.txtMaSan.TabIndex = 8;
            // 
            // txtTenSan
            // 
            // 
            // 
            // 
            this.txtTenSan.Border.Class = "TextBoxBorder";
            this.txtTenSan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenSan.Location = new System.Drawing.Point(239, 48);
            this.txtTenSan.Name = "txtTenSan";
            this.txtTenSan.PreventEnterBeep = true;
            this.txtTenSan.Size = new System.Drawing.Size(124, 20);
            this.txtTenSan.TabIndex = 9;
            // 
            // txtKichThuoc
            // 
            // 
            // 
            // 
            this.txtKichThuoc.Border.Class = "TextBoxBorder";
            this.txtKichThuoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKichThuoc.Location = new System.Drawing.Point(239, 91);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.PreventEnterBeep = true;
            this.txtKichThuoc.Size = new System.Drawing.Size(124, 20);
            this.txtKichThuoc.TabIndex = 10;
            // 
            // lblMaSan
            // 
            // 
            // 
            // 
            this.lblMaSan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMaSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSan.Location = new System.Drawing.Point(163, 12);
            this.lblMaSan.Name = "lblMaSan";
            this.lblMaSan.Size = new System.Drawing.Size(70, 23);
            this.lblMaSan.TabIndex = 11;
            this.lblMaSan.Text = "Mã Sân :";
            // 
            // lblTenSan
            // 
            // 
            // 
            // 
            this.lblTenSan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTenSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSan.Location = new System.Drawing.Point(163, 48);
            this.lblTenSan.Name = "lblTenSan";
            this.lblTenSan.Size = new System.Drawing.Size(70, 23);
            this.lblTenSan.TabIndex = 12;
            this.lblTenSan.Text = "Tên Sân :";
            // 
            // lblKichThuoc
            // 
            // 
            // 
            // 
            this.lblKichThuoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblKichThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKichThuoc.Location = new System.Drawing.Point(139, 88);
            this.lblKichThuoc.Name = "lblKichThuoc";
            this.lblKichThuoc.Size = new System.Drawing.Size(94, 23);
            this.lblKichThuoc.TabIndex = 13;
            this.lblKichThuoc.Text = "Kích Thước :";
            // 
            // lblGiaThue
            // 
            // 
            // 
            // 
            this.lblGiaThue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGiaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaThue.Location = new System.Drawing.Point(153, 128);
            this.lblGiaThue.Name = "lblGiaThue";
            this.lblGiaThue.Size = new System.Drawing.Size(80, 23);
            this.lblGiaThue.TabIndex = 14;
            this.lblGiaThue.Text = "Giá Thuê :";
            // 
            // txtGiaThue
            // 
            // 
            // 
            // 
            this.txtGiaThue.Border.Class = "TextBoxBorder";
            this.txtGiaThue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaThue.Location = new System.Drawing.Point(239, 131);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.PreventEnterBeep = true;
            this.txtGiaThue.Size = new System.Drawing.Size(124, 20);
            this.txtGiaThue.TabIndex = 15;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::QuanLySanBong.Properties.Resources.sanbongne;
            this.pictureBox6.Location = new System.Drawing.Point(142, 192);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(221, 185);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QuanLySanBong.Properties.Resources.pencil_tip_34px;
            this.pictureBox4.Location = new System.Drawing.Point(0, 131);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 37);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLySanBong.Properties.Resources.available_updates_34px;
            this.pictureBox3.Location = new System.Drawing.Point(0, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLySanBong.Properties.Resources.delete_25px;
            this.pictureBox2.Location = new System.Drawing.Point(0, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 40);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLySanBong.Properties.Resources.plus_25px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnTrungGian
            // 
            this.btnTrungGian.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTrungGian.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTrungGian.Location = new System.Drawing.Point(288, 157);
            this.btnTrungGian.Name = "btnTrungGian";
            this.btnTrungGian.Size = new System.Drawing.Size(75, 29);
            this.btnTrungGian.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTrungGian.TabIndex = 18;
            this.btnTrungGian.Text = "...";
            this.btnTrungGian.Click += new System.EventHandler(this.btnTrungGian_Click);
            // 
            // lblTim
            // 
            // 
            // 
            // 
            this.lblTim.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTim.Location = new System.Drawing.Point(0, 206);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(36, 23);
            this.lblTim.TabIndex = 20;
            this.lblTim.Text = "Tìm:";
            // 
            // txtTim
            // 
            // 
            // 
            // 
            this.txtTim.Border.Class = "TextBoxBorder";
            this.txtTim.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTim.Location = new System.Drawing.Point(31, 206);
            this.txtTim.Name = "txtTim";
            this.txtTim.PreventEnterBeep = true;
            this.txtTim.Size = new System.Drawing.Size(105, 20);
            this.txtTim.TabIndex = 21;
            // 
            // btnTroLai
            // 
            this.btnTroLai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTroLai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTroLai.Location = new System.Drawing.Point(120, 9);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(37, 23);
            this.btnTroLai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTroLai.TabIndex = 22;
            this.btnTroLai.Text = "<-";
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // frmSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 389);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lblTim);
            this.Controls.Add(this.btnTrungGian);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtGiaThue);
            this.Controls.Add(this.lblGiaThue);
            this.Controls.Add(this.lblKichThuoc);
            this.Controls.Add(this.lblTenSan);
            this.Controls.Add(this.lblMaSan);
            this.Controls.Add(this.txtKichThuoc);
            this.Controls.Add(this.txtTenSan);
            this.Controls.Add(this.txtMaSan);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvSanBong);
            this.Name = "frmSan";
            this.Text = "frmSan";
            this.Load += new System.EventHandler(this.frmSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lvSanBong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevComponents.DotNetBar.ButtonX btnCapNhat;
        private System.Windows.Forms.PictureBox pictureBox4;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaSan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenSan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKichThuoc;
        private DevComponents.DotNetBar.LabelX lblMaSan;
        private DevComponents.DotNetBar.LabelX lblTenSan;
        private DevComponents.DotNetBar.LabelX lblKichThuoc;
        private DevComponents.DotNetBar.LabelX lblGiaThue;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaThue;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevComponents.DotNetBar.ButtonX btnTrungGian;
        private DevComponents.DotNetBar.LabelX lblTim;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTim;
        private DevComponents.DotNetBar.ButtonX btnTroLai;
    }
}