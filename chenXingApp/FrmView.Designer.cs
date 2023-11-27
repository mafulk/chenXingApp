namespace chenXingApp
{
    partial class FrmView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.subPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.subExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.subExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miView = new System.Windows.Forms.ToolStripMenuItem();
            this.subView = new System.Windows.Forms.ToolStripMenuItem();
            this.subFind = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managementBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miView,
            this.miExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subPrint,
            this.subExcel,
            this.subExit});
            this.miFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(49, 24);
            this.miFile.Text = "文件";
            // 
            // subPrint
            // 
            this.subPrint.Name = "subPrint";
            this.subPrint.Size = new System.Drawing.Size(176, 24);
            this.subPrint.Text = "打印个人信息表";
            // 
            // subExcel
            // 
            this.subExcel.Name = "subExcel";
            this.subExcel.Size = new System.Drawing.Size(176, 24);
            this.subExcel.Text = "导出Excel文件";
            // 
            // subExit
            // 
            this.subExit.Name = "subExit";
            this.subExit.Size = new System.Drawing.Size(176, 24);
            this.subExit.Text = "退出";
            this.subExit.Click += new System.EventHandler(this.subExit_Click);
            // 
            // miView
            // 
            this.miView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subView,
            this.subFind});
            this.miView.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.miView.Name = "miView";
            this.miView.Size = new System.Drawing.Size(77, 24);
            this.miView.Text = "人员浏览";
            // 
            // subView
            // 
            this.subView.Name = "subView";
            this.subView.Size = new System.Drawing.Size(134, 24);
            this.subView.Text = "人员总览";
            this.subView.Click += new System.EventHandler(this.subView_Click);
            // 
            // subFind
            // 
            this.subFind.Name = "subFind";
            this.subFind.Size = new System.Drawing.Size(134, 24);
            this.subFind.Text = "人员查找";
            // 
            // miExit
            // 
            this.miExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(49, 24);
            this.miExit.Text = "退出";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 977);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 11F);
            this.button1.Location = new System.Drawing.Point(147, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "搜 索";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("宋体", 11F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(66, 137);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 23);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "人才库";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "类 型";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓 名";
            // 
            // DGVView
            // 
            this.DGVView.AllowUserToAddRows = false;
            this.DGVView.AllowUserToDeleteRows = false;
            this.DGVView.AllowUserToResizeRows = false;
            this.DGVView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGVView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.DGVView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column13,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column11,
            this.Column12,
            this.Column10,
            this.Column14});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVView.GridColor = System.Drawing.Color.LightGray;
            this.DGVView.Location = new System.Drawing.Point(280, 32);
            this.DGVView.Name = "DGVView";
            this.DGVView.RowTemplate.Height = 23;
            this.DGVView.Size = new System.Drawing.Size(1612, 977);
            this.DGVView.TabIndex = 5;
            this.DGVView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVView_CellContentClick);
            this.DGVView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DGVView_RowStateChanged);
            this.DGVView.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DGVView_Scroll);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MName";
            this.Column1.HeaderText = "姓名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MSex";
            this.Column2.HeaderText = "性别";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MBirthdate";
            this.Column3.HeaderText = "出生日期";
            this.Column3.Name = "Column3";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "MJiguan";
            this.Column13.HeaderText = "籍贯";
            this.Column13.Name = "Column13";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MXueli";
            this.Column4.HeaderText = "学历";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MXuewei";
            this.Column5.HeaderText = "学位";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MSchool";
            this.Column6.HeaderText = "学校";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MProf";
            this.Column7.HeaderText = "专业";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MZhicheng";
            this.Column8.HeaderText = "职称";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MPhone";
            this.Column9.HeaderText = "电话";
            this.Column9.Name = "Column9";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MDanwei";
            this.Column11.HeaderText = "单位";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "MZhuzhi";
            this.Column12.HeaderText = "住址";
            this.Column12.Name = "Column12";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "MCategory";
            this.Column10.HeaderText = "人才类型";
            this.Column10.Name = "Column10";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "MKu";
            this.Column14.HeaderText = "人才库";
            this.Column14.Name = "Column14";
            // 
            // managementBindingSource
            // 
            this.managementBindingSource.DataSource = typeof(chenXingApp.Management);
            // 
            // managementBindingSource1
            // 
            this.managementBindingSource1.DataSource = typeof(chenXingApp.Management);
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1904, 1021);
            this.Controls.Add(this.DGVView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "FrmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 人员浏览";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmView_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem subPrint;
        private System.Windows.Forms.ToolStripMenuItem subExcel;
        private System.Windows.Forms.ToolStripMenuItem subExit;
        private System.Windows.Forms.ToolStripMenuItem miView;
        private System.Windows.Forms.ToolStripMenuItem subView;
        private System.Windows.Forms.ToolStripMenuItem subFind;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView DGVView;
        private System.Windows.Forms.BindingSource managementBindingSource;
        private System.Windows.Forms.BindingSource managementBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}