namespace QLHocSinhMamNon
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
            this.tcHS = new System.Windows.Forms.TabControl();
            this.tpHS = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tpGV = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tpNV = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tpPH = new System.Windows.Forms.TabPage();
            this.tpCBYT = new System.Windows.Forms.TabPage();
            this.tpL = new System.Windows.Forms.TabPage();
            this.cboChonLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tcHS.SuspendLayout();
            this.tpHS.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpGV.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpNV.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcHS
            // 
            this.tcHS.Controls.Add(this.tpHS);
            this.tcHS.Controls.Add(this.tpGV);
            this.tcHS.Controls.Add(this.tpNV);
            this.tcHS.Controls.Add(this.tpPH);
            this.tcHS.Controls.Add(this.tpCBYT);
            this.tcHS.Controls.Add(this.tpL);
            this.tcHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcHS.Location = new System.Drawing.Point(0, 0);
            this.tcHS.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tcHS.Name = "tcHS";
            this.tcHS.SelectedIndex = 0;
            this.tcHS.Size = new System.Drawing.Size(1333, 813);
            this.tcHS.TabIndex = 5;
            // 
            // tpHS
            // 
            this.tpHS.Controls.Add(this.dgvHocSinh);
            this.tpHS.Controls.Add(this.panel1);
            this.tpHS.Location = new System.Drawing.Point(4, 30);
            this.tpHS.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpHS.Name = "tpHS";
            this.tpHS.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpHS.Size = new System.Drawing.Size(1325, 779);
            this.tpHS.TabIndex = 0;
            this.tpHS.Text = "Quản lý học sinh";
            this.tpHS.UseVisualStyleBackColor = true;
            this.tpHS.Click += new System.EventHandler(this.tpHS_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboChonLop);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 88);
            this.panel1.TabIndex = 7;
            // 
            // btnSua
            // 
            this.btnSua.AllowDrop = true;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Image = global::QLHocSinhMamNon.Properties.Resources.icons8_money_24;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(243, 6);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSua.Size = new System.Drawing.Size(108, 77);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa thông tin học sinh";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.AllowDrop = true;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = global::QLHocSinhMamNon.Properties.Resources.icons8_bill_24;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(125, 5);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXoa.Size = new System.Drawing.Size(108, 77);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa thông tin học sinh";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.AllowDrop = true;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QLHocSinhMamNon.Properties.Resources.icons8_student_24;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(7, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThem.Size = new System.Drawing.Size(108, 78);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm học sinh mới";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // tpGV
            // 
            this.tpGV.Controls.Add(this.dataGridView1);
            this.tpGV.Controls.Add(this.panel2);
            this.tpGV.Location = new System.Drawing.Point(4, 30);
            this.tpGV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpGV.Name = "tpGV";
            this.tpGV.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpGV.Size = new System.Drawing.Size(1325, 779);
            this.tpGV.TabIndex = 1;
            this.tpGV.Text = "Quản lý giáo viên";
            this.tpGV.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(13, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 90);
            this.panel2.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.AllowDrop = true;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::QLHocSinhMamNon.Properties.Resources.icons8_folder_24;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(125, 5);
            this.button7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(115, 77);
            this.button7.TabIndex = 5;
            this.button7.Text = "Xóa thông tin giáo viên";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.AllowDrop = true;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::QLHocSinhMamNon.Properties.Resources.icons8_teacher_24;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(7, 5);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(108, 77);
            this.button6.TabIndex = 4;
            this.button6.Text = "Thêm giáo viên mới";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tpNV
            // 
            this.tpNV.Controls.Add(this.tabControl3);
            this.tpNV.Controls.Add(this.panel3);
            this.tpNV.Location = new System.Drawing.Point(4, 30);
            this.tpNV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpNV.Name = "tpNV";
            this.tpNV.Size = new System.Drawing.Size(1325, 779);
            this.tpNV.TabIndex = 2;
            this.tpNV.Text = "Quản lý nhân viên";
            this.tpNV.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.tabPage1);
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Location = new System.Drawing.Point(13, 126);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1293, 624);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage1.Size = new System.Drawing.Size(1285, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(10, 10);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1260, 570);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage3.Size = new System.Drawing.Size(1285, 606);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Location = new System.Drawing.Point(13, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1293, 111);
            this.panel3.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.AllowDrop = true;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::QLHocSinhMamNon.Properties.Resources.icons8_folder_24;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(148, 5);
            this.button9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button9.Name = "button9";
            this.button9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button9.Size = new System.Drawing.Size(115, 100);
            this.button9.TabIndex = 6;
            this.button9.Text = "Danh sách nhân viên";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.AllowDrop = true;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::QLHocSinhMamNon.Properties.Resources.icons8_employee_24;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(7, 5);
            this.button8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button8.Name = "button8";
            this.button8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button8.Size = new System.Drawing.Size(118, 100);
            this.button8.TabIndex = 5;
            this.button8.Text = "Thêm nhân viên mới";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // tpPH
            // 
            this.tpPH.Location = new System.Drawing.Point(4, 30);
            this.tpPH.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpPH.Name = "tpPH";
            this.tpPH.Size = new System.Drawing.Size(1325, 779);
            this.tpPH.TabIndex = 3;
            this.tpPH.Text = "Quản lý phụ huynh";
            this.tpPH.UseVisualStyleBackColor = true;
            // 
            // tpCBYT
            // 
            this.tpCBYT.Location = new System.Drawing.Point(4, 30);
            this.tpCBYT.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpCBYT.Name = "tpCBYT";
            this.tpCBYT.Size = new System.Drawing.Size(1325, 779);
            this.tpCBYT.TabIndex = 4;
            this.tpCBYT.Text = "Quản lý cán bộ y tế";
            this.tpCBYT.UseVisualStyleBackColor = true;
            // 
            // tpL
            // 
            this.tpL.Location = new System.Drawing.Point(4, 30);
            this.tpL.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpL.Name = "tpL";
            this.tpL.Size = new System.Drawing.Size(1325, 779);
            this.tpL.TabIndex = 5;
            this.tpL.Text = "Quản lý lớp học";
            this.tpL.UseVisualStyleBackColor = true;
            // 
            // cboChonLop
            // 
            this.cboChonLop.FormattingEnabled = true;
            this.cboChonLop.Location = new System.Drawing.Point(988, 33);
            this.cboChonLop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Size = new System.Drawing.Size(199, 29);
            this.cboChonLop.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1197, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chọn lớp";
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Location = new System.Drawing.Point(13, 107);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(1297, 664);
            this.dgvHocSinh.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::QLHocSinhMamNon.Properties.Resources.icons8_folder_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(250, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(115, 77);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sửa thông tin giáo viên";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1297, 663);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::QLHocSinhMamNon.Properties.Resources.icons8_money_24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(361, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(108, 77);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thông tin điểm danh";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 813);
            this.Controls.Add(this.tcHS);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tcHS.ResumeLayout(false);
            this.tpHS.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpGV.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tpNV.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcHS;
        private System.Windows.Forms.TabPage tpHS;
        private System.Windows.Forms.TabPage tpGV;
        private System.Windows.Forms.TabPage tpNV;
        private System.Windows.Forms.TabPage tpPH;
        private System.Windows.Forms.TabPage tpCBYT;
        private System.Windows.Forms.TabPage tpL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChonLop;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}

