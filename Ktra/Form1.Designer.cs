namespace Ktra
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.themNhom = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.xoaNhom = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.themLienLac = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.xoaLienLac = new System.Windows.Forms.ToolStripLabel();
            this.labeltengoi = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSoDienThoai = new System.Windows.Forms.TextBox();
            this.bindingSourcelienlac = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcenhom = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcelienlac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcenhom)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.tennhom});
            this.dataGridView1.Location = new System.Drawing.Point(5, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(253, 415);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column2,
            this.Column3,
            this.Column4,
            this.diachi,
            this.idnhom});
            this.dataGridView2.Location = new System.Drawing.Point(264, 30);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(536, 254);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Column5";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Tên gọi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "emali";
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sdt";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "diachi";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Visible = false;
            this.diachi.Width = 125;
            // 
            // idnhom
            // 
            this.idnhom.DataPropertyName = "idnhom";
            this.idnhom.HeaderText = "Column5";
            this.idnhom.MinimumWidth = 6;
            this.idnhom.Name = "idnhom";
            this.idnhom.Visible = false;
            this.idnhom.Width = 125;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.themNhom,
            this.toolStripButton2,
            this.xoaNhom,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.themLienLac,
            this.toolStripButton4,
            this.xoaLienLac});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // themNhom
            // 
            this.themNhom.Name = "themNhom";
            this.themNhom.Size = new System.Drawing.Size(88, 24);
            this.themNhom.Text = "Thêm nhóm";
            this.themNhom.Click += new System.EventHandler(this.ToolStripLabel1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // xoaNhom
            // 
            this.xoaNhom.Name = "xoaNhom";
            this.xoaNhom.Size = new System.Drawing.Size(77, 24);
            this.xoaNhom.Text = "Xóa nhóm";
            this.xoaNhom.Click += new System.EventHandler(this.xoaNhom_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // themLienLac
            // 
            this.themLienLac.Name = "themLienLac";
            this.themLienLac.Size = new System.Drawing.Size(97, 24);
            this.themLienLac.Text = "Thêm liên lạc";
            this.themLienLac.Click += new System.EventHandler(this.themLienLac_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // xoaLienLac
            // 
            this.xoaLienLac.Name = "xoaLienLac";
            this.xoaLienLac.Size = new System.Drawing.Size(86, 24);
            this.xoaLienLac.Text = "Xóa liên lạc";
            this.xoaLienLac.Click += new System.EventHandler(this.xoaLienLac_Click);
            // 
            // labeltengoi
            // 
            this.labeltengoi.AutoSize = true;
            this.labeltengoi.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltengoi.Location = new System.Drawing.Point(337, 295);
            this.labeltengoi.Name = "labeltengoi";
            this.labeltengoi.Size = new System.Drawing.Size(145, 37);
            this.labeltengoi.TabIndex = 7;
            this.labeltengoi.Text = "[Tên gọi]";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(664, 2);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(136, 22);
            this.tbTimKiem.TabIndex = 8;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.TbTimKiem_TextChanged);
            this.tbTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTimKiem_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập từ cần tìm";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số điện thoại:";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(453, 354);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(345, 22);
            this.tbDiaChi.TabIndex = 13;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(453, 385);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(345, 22);
            this.tbEmail.TabIndex = 14;
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.Location = new System.Drawing.Point(453, 414);
            this.tbSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.Size = new System.Drawing.Size(345, 22);
            this.tbSoDienThoai.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // tennhom
            // 
            this.tennhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tennhom.DataPropertyName = "tennhom";
            this.tennhom.HeaderText = "Tên nhóm";
            this.tennhom.MinimumWidth = 6;
            this.tennhom.Name = "tennhom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.tbSoDienThoai);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.labeltengoi);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ DANH BẠ - [Họ tên sinh viên]";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcelienlac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcenhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel themNhom;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel xoaNhom;
        private System.Windows.Forms.Label labeltengoi;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel themLienLac;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel xoaLienLac;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSoDienThoai;
        private System.Windows.Forms.BindingSource bindingSourcelienlac;
        private System.Windows.Forms.BindingSource bindingSourcenhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhom;
    }
}

