namespace Final
{
    partial class QuanLySV
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbbDanToc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbViecLam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.ma_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dan_toc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.que_quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa_hoc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoc_luc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganh_dao_tao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganh_nghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_co_quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNganh = new System.Windows.Forms.Panel();
            this.pnlHocLuc = new System.Windows.Forms.Panel();
            this.pnlKhoa = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.quickFilter = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới tính";
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DisplayMember = "Nam";
            this.cbbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Cả hai",
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(76, 70);
            this.cbbGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(50, 21);
            this.cbbGioiTinh.TabIndex = 9;
            this.cbbGioiTinh.ValueMember = "Nam";
            // 
            // cbbDanToc
            // 
            this.cbbDanToc.DisplayMember = "Nam";
            this.cbbDanToc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbbDanToc.FormattingEnabled = true;
            this.cbbDanToc.Items.AddRange(new object[] {
            "Cả hai",
            "Kinh",
            "Khác"});
            this.cbbDanToc.Location = new System.Drawing.Point(76, 99);
            this.cbbDanToc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDanToc.Name = "cbbDanToc";
            this.cbbDanToc.Size = new System.Drawing.Size(50, 21);
            this.cbbDanToc.TabIndex = 11;
            this.cbbDanToc.ValueMember = "Nam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dân tộc";
            // 
            // cbbViecLam
            // 
            this.cbbViecLam.DisplayMember = "Chọn...";
            this.cbbViecLam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbbViecLam.FormattingEnabled = true;
            this.cbbViecLam.Items.AddRange(new object[] {
            "Cả hai",
            "Đã có việc làm",
            "Chưa có việc làm"});
            this.cbbViecLam.Location = new System.Drawing.Point(713, 66);
            this.cbbViecLam.Margin = new System.Windows.Forms.Padding(2);
            this.cbbViecLam.Name = "cbbViecLam";
            this.cbbViecLam.Size = new System.Drawing.Size(113, 21);
            this.cbbViecLam.TabIndex = 14;
            this.cbbViecLam.ValueMember = "Nam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(655, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Việc làm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngành";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(162)))));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(254, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(408, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Khóa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(141, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Học lực";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvStudent);
            this.panel2.Location = new System.Drawing.Point(15, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 353);
            this.panel2.TabIndex = 23;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_sv,
            this.ho_ten,
            this.ngay_sinh,
            this.gioi_tinh,
            this.dan_toc,
            this.que_quan,
            this.khoa_hoc2,
            this.hoc_luc,
            this.nganh_dao_tao,
            this.nganh_nghe,
            this.ten_co_quan});
            this.dgvStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.Size = new System.Drawing.Size(954, 353);
            this.dgvStudent.TabIndex = 0;
            // 
            // ma_sv
            // 
            this.ma_sv.DataPropertyName = "ma_sinh_vien";
            this.ma_sv.HeaderText = "Mã sinh viên";
            this.ma_sv.Name = "ma_sv";
            this.ma_sv.ReadOnly = true;
            this.ma_sv.Width = 80;
            // 
            // ho_ten
            // 
            this.ho_ten.DataPropertyName = "ho_ten";
            this.ho_ten.HeaderText = "Họ tên";
            this.ho_ten.Name = "ho_ten";
            this.ho_ten.ReadOnly = true;
            this.ho_ten.Width = 120;
            // 
            // ngay_sinh
            // 
            this.ngay_sinh.DataPropertyName = "ngay_sinh";
            this.ngay_sinh.HeaderText = "Ngày sinh";
            this.ngay_sinh.Name = "ngay_sinh";
            this.ngay_sinh.ReadOnly = true;
            this.ngay_sinh.Width = 80;
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.DataPropertyName = "gioi_tinh";
            this.gioi_tinh.FillWeight = 70F;
            this.gioi_tinh.HeaderText = "Giới tính";
            this.gioi_tinh.Name = "gioi_tinh";
            this.gioi_tinh.ReadOnly = true;
            this.gioi_tinh.Width = 50;
            // 
            // dan_toc
            // 
            this.dan_toc.DataPropertyName = "dan_toc";
            this.dan_toc.FillWeight = 70F;
            this.dan_toc.HeaderText = "Dân tộc";
            this.dan_toc.Name = "dan_toc";
            this.dan_toc.ReadOnly = true;
            this.dan_toc.Width = 50;
            // 
            // que_quan
            // 
            this.que_quan.DataPropertyName = "que_quan";
            this.que_quan.HeaderText = "Quê quán";
            this.que_quan.Name = "que_quan";
            this.que_quan.ReadOnly = true;
            this.que_quan.Width = 60;
            // 
            // khoa_hoc2
            // 
            this.khoa_hoc2.DataPropertyName = "ma_khoa_hoc";
            this.khoa_hoc2.FillWeight = 70F;
            this.khoa_hoc2.HeaderText = "Khóa học";
            this.khoa_hoc2.Name = "khoa_hoc2";
            this.khoa_hoc2.ReadOnly = true;
            this.khoa_hoc2.Width = 80;
            // 
            // hoc_luc
            // 
            this.hoc_luc.DataPropertyName = "hoc_luc";
            this.hoc_luc.HeaderText = "Học lực";
            this.hoc_luc.Name = "hoc_luc";
            this.hoc_luc.ReadOnly = true;
            this.hoc_luc.Width = 70;
            // 
            // nganh_dao_tao
            // 
            this.nganh_dao_tao.DataPropertyName = "ten_nganh_dao_tao";
            this.nganh_dao_tao.HeaderText = "Ngành đào tạo";
            this.nganh_dao_tao.Name = "nganh_dao_tao";
            this.nganh_dao_tao.ReadOnly = true;
            this.nganh_dao_tao.Width = 120;
            // 
            // nganh_nghe
            // 
            this.nganh_nghe.DataPropertyName = "ten_nganh_lam_viec";
            this.nganh_nghe.HeaderText = "Ngành nghề";
            this.nganh_nghe.Name = "nganh_nghe";
            this.nganh_nghe.ReadOnly = true;
            this.nganh_nghe.Width = 120;
            // 
            // ten_co_quan
            // 
            this.ten_co_quan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_co_quan.DataPropertyName = "ten_co_quan";
            this.ten_co_quan.HeaderText = "Tên cơ quan";
            this.ten_co_quan.Name = "ten_co_quan";
            this.ten_co_quan.ReadOnly = true;
            // 
            // pnlNganh
            // 
            this.pnlNganh.AutoScroll = true;
            this.pnlNganh.BackColor = System.Drawing.Color.White;
            this.pnlNganh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNganh.Location = new System.Drawing.Point(324, 66);
            this.pnlNganh.Name = "pnlNganh";
            this.pnlNganh.Size = new System.Drawing.Size(181, 75);
            this.pnlNganh.TabIndex = 26;
            // 
            // pnlHocLuc
            // 
            this.pnlHocLuc.AutoScroll = true;
            this.pnlHocLuc.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.pnlHocLuc.BackColor = System.Drawing.Color.White;
            this.pnlHocLuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHocLuc.Location = new System.Drawing.Point(187, 66);
            this.pnlHocLuc.Name = "pnlHocLuc";
            this.pnlHocLuc.Size = new System.Drawing.Size(88, 75);
            this.pnlHocLuc.TabIndex = 27;
            // 
            // pnlKhoa
            // 
            this.pnlKhoa.AutoScroll = true;
            this.pnlKhoa.BackColor = System.Drawing.Color.White;
            this.pnlKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKhoa.Location = new System.Drawing.Point(557, 67);
            this.pnlKhoa.Name = "pnlKhoa";
            this.pnlKhoa.Size = new System.Drawing.Size(80, 73);
            this.pnlKhoa.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Final.Properties.Resources.import;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(855, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 31;
            this.button1.Text = "Import Excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = global::Final.Properties.Resources.refresh;
            this.btnLamMoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLamMoi.Location = new System.Drawing.Point(371, 551);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 41);
            this.btnLamMoi.TabIndex = 30;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Image = global::Final.Properties.Resources.view;
            this.btnXem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXem.Location = new System.Drawing.Point(874, 551);
            this.btnXem.Margin = new System.Windows.Forms.Padding(2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(96, 41);
            this.btnXem.TabIndex = 29;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // quickFilter
            // 
            this.quickFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.quickFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quickFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.quickFilter.ForeColor = System.Drawing.Color.White;
            this.quickFilter.Image = global::Final.Properties.Resources.look;
            this.quickFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quickFilter.Location = new System.Drawing.Point(713, 101);
            this.quickFilter.Margin = new System.Windows.Forms.Padding(2);
            this.quickFilter.Name = "quickFilter";
            this.quickFilter.Size = new System.Drawing.Size(113, 40);
            this.quickFilter.TabIndex = 22;
            this.quickFilter.Text = "Lọc nhanh";
            this.quickFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.quickFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quickFilter.UseVisualStyleBackColor = false;
            this.quickFilter.Click += new System.EventHandler(this.quickFilter_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Image = global::Final.Properties.Resources._return;
            this.btnQuayLai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuayLai.Location = new System.Drawing.Point(232, 551);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(106, 41);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::Final.Properties.Resources.add;
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(497, 551);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 41);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::Final.Properties.Resources.edit;
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSua.Location = new System.Drawing.Point(632, 551);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 41);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::Final.Properties.Resources.delete;
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoa.Location = new System.Drawing.Point(755, 551);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // QuanLySV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 612);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.pnlKhoa);
            this.Controls.Add(this.pnlHocLuc);
            this.Controls.Add(this.pnlNganh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.quickFilter);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbViecLam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbDanToc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.label4);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Final.Properties.Settings.Default, "Tuan", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = global::Final.Properties.Settings.Default.Tuan;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "QuanLySV";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.Load += new System.EventHandler(this.GUI_SinhVien_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.ComboBox cbbDanToc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbViecLam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button quickFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Panel pnlNganh;
        private System.Windows.Forms.Panel pnlHocLuc;
        private System.Windows.Forms.Panel pnlKhoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dan_toc;
        private System.Windows.Forms.DataGridViewTextBoxColumn que_quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa_hoc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoc_luc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nganh_dao_tao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nganh_nghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_co_quan;
    }
}