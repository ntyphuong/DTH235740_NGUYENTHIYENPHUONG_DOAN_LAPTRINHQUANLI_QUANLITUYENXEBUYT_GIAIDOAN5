namespace quanLiXeBuyt.GiaoDien
{
    partial class ucQuanLyXe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picXeBus = new System.Windows.Forms.PictureBox();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.btnSuaXe = new System.Windows.Forms.Button();
            this.btnXoaXe = new System.Windows.Forms.Button();
            this.btnThemXe = new System.Windows.Forms.Button();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXeBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.picXeBus);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 800);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTrangThai);
            this.groupBox1.Controls.Add(this.txtBienSo);
            this.groupBox1.Controls.Add(this.btnSuaXe);
            this.groupBox1.Controls.Add(this.btnXoaXe);
            this.groupBox1.Controls.Add(this.btnThemXe);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvXe);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 800);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xe";
            // 
            // picXeBus
            // 
            this.picXeBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picXeBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picXeBus.Location = new System.Drawing.Point(0, 362);
            this.picXeBus.Name = "picXeBus";
            this.picXeBus.Size = new System.Drawing.Size(400, 438);
            this.picXeBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXeBus.TabIndex = 1;
            this.picXeBus.TabStop = false;
            this.picXeBus.Click += new System.EventHandler(this.picXeBus_Click);
            // 
            // dgvXe
            // 
            this.dgvXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXe.Location = new System.Drawing.Point(3, 22);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersWidth = 62;
            this.dgvXe.RowTemplate.Height = 28;
            this.dgvXe.Size = new System.Drawing.Size(790, 775);
            this.dgvXe.TabIndex = 0;
            this.dgvXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_CellClick);
            // 
            // btnSuaXe
            // 
            this.btnSuaXe.AutoSize = true;
            this.btnSuaXe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSuaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaXe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaXe.Location = new System.Drawing.Point(3, 152);
            this.btnSuaXe.Name = "btnSuaXe";
            this.btnSuaXe.Size = new System.Drawing.Size(394, 69);
            this.btnSuaXe.TabIndex = 10;
            this.btnSuaXe.Text = "Sửa Xe";
            this.btnSuaXe.UseVisualStyleBackColor = true;
            this.btnSuaXe.Click += new System.EventHandler(this.btnSuaXe_Click_1);
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.AutoSize = true;
            this.btnXoaXe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnXoaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaXe.ForeColor = System.Drawing.Color.Red;
            this.btnXoaXe.Location = new System.Drawing.Point(3, 221);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(394, 69);
            this.btnXoaXe.TabIndex = 9;
            this.btnXoaXe.Text = "Xóa xe";
            this.btnXoaXe.UseVisualStyleBackColor = true;
            this.btnXoaXe.Click += new System.EventHandler(this.btnXoaXe_Click_1);
            // 
            // btnThemXe
            // 
            this.btnThemXe.AutoSize = true;
            this.btnThemXe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThemXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemXe.Location = new System.Drawing.Point(3, 290);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(394, 69);
            this.btnThemXe.TabIndex = 8;
            this.btnThemXe.Text = "Thêm xe";
            this.btnThemXe.UseVisualStyleBackColor = true;
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click_1);
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(156, 62);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(201, 26);
            this.txtBienSo.TabIndex = 11;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Sẵn sàng",
            "Bảo trì",
            "Đang chạy"});
            this.cboTrangThai.Location = new System.Drawing.Point(156, 111);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(201, 28);
            this.cboTrangThai.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "XE BUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Biển số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Trạng thái";
            // 
            // ucQuanLyXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucQuanLyXe";
            this.Size = new System.Drawing.Size(1200, 800);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picXeBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picXeBus;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Button btnSuaXe;
        private System.Windows.Forms.Button btnXoaXe;
        private System.Windows.Forms.Button btnThemXe;
    }
}
