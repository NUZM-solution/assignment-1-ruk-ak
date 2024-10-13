namespace stuinfo
{
    partial class RukaiyaAkram
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
            this.txt_name = new System.Windows.Forms.Label();
            this.txt_rollNo = new System.Windows.Forms.Label();
            this.cmb_degree = new System.Windows.Forms.Label();
            this.cmb_semester = new System.Windows.Forms.Label();
            this.txtcoursetitle = new System.Windows.Forms.TextBox();
            this.txtobtainmarks = new System.Windows.Forms.TextBox();
            this.txtcoursecode = new System.Windows.Forms.TextBox();
            this.cmbgrade = new System.Windows.Forms.ComboBox();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_gpa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(6, 30);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(132, 27);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "Course Title";
            // 
            // txt_rollNo
            // 
            this.txt_rollNo.AutoSize = true;
            this.txt_rollNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_rollNo.Location = new System.Drawing.Point(306, 32);
            this.txt_rollNo.Name = "txt_rollNo";
            this.txt_rollNo.Size = new System.Drawing.Size(138, 27);
            this.txt_rollNo.TabIndex = 2;
            this.txt_rollNo.Text = "Course Code";
            // 
            // cmb_degree
            // 
            this.cmb_degree.AutoSize = true;
            this.cmb_degree.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_degree.Location = new System.Drawing.Point(634, 35);
            this.cmb_degree.Name = "cmb_degree";
            this.cmb_degree.Size = new System.Drawing.Size(72, 27);
            this.cmb_degree.TabIndex = 4;
            this.cmb_degree.Text = "Grade";
            // 
            // cmb_semester
            // 
            this.cmb_semester.AutoSize = true;
            this.cmb_semester.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_semester.Location = new System.Drawing.Point(898, 34);
            this.cmb_semester.Name = "cmb_semester";
            this.cmb_semester.Size = new System.Drawing.Size(75, 27);
            this.cmb_semester.TabIndex = 5;
            this.cmb_semester.Text = "Status";
            // 
            // txtcoursetitle
            // 
            this.txtcoursetitle.Location = new System.Drawing.Point(160, 32);
            this.txtcoursetitle.Name = "txtcoursetitle";
            this.txtcoursetitle.Size = new System.Drawing.Size(128, 26);
            this.txtcoursetitle.TabIndex = 7;
            // 
            // txtobtainmarks
            // 
            this.txtobtainmarks.Location = new System.Drawing.Point(1375, 46);
            this.txtobtainmarks.Name = "txtobtainmarks";
            this.txtobtainmarks.Size = new System.Drawing.Size(133, 26);
            this.txtobtainmarks.TabIndex = 9;
            // 
            // txtcoursecode
            // 
            this.txtcoursecode.Location = new System.Drawing.Point(460, 33);
            this.txtcoursecode.Name = "txtcoursecode";
            this.txtcoursecode.Size = new System.Drawing.Size(138, 26);
            this.txtcoursecode.TabIndex = 10;
            // 
            // cmbgrade
            // 
            this.cmbgrade.FormattingEnabled = true;
            this.cmbgrade.Items.AddRange(new object[] {
            "A+",
            "A",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D",
            "F"});
            this.cmbgrade.Location = new System.Drawing.Point(731, 33);
            this.cmbgrade.Name = "cmbgrade";
            this.cmbgrade.Size = new System.Drawing.Size(146, 28);
            this.cmbgrade.TabIndex = 11;
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Pass",
            "Fail"});
            this.cmbstatus.Location = new System.Drawing.Point(991, 33);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(146, 28);
            this.cmbstatus.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1539, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 211);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1484, 294);
            this.dataGridView2.TabIndex = 14;
            // 
            // txt_gpa
            // 
            this.txt_gpa.AutoSize = true;
            this.txt_gpa.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_gpa.Location = new System.Drawing.Point(1153, 35);
            this.txt_gpa.Name = "txt_gpa";
            this.txt_gpa.Size = new System.Drawing.Size(174, 27);
            this.txt_gpa.TabIndex = 3;
            this.txt_gpa.Text = "Obtained Marks";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txtcoursetitle);
            this.groupBox1.Controls.Add(this.cmbstatus);
            this.groupBox1.Controls.Add(this.txt_gpa);
            this.groupBox1.Controls.Add(this.txt_rollNo);
            this.groupBox1.Controls.Add(this.cmbgrade);
            this.groupBox1.Controls.Add(this.cmb_semester);
            this.groupBox1.Controls.Add(this.txtcoursecode);
            this.groupBox1.Controls.Add(this.cmb_degree);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1621, 110);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // RukaiyaAkram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 466);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtobtainmarks);
            this.Controls.Add(this.groupBox1);
            this.Name = "RukaiyaAkram";
            this.Text = "RukaiyaAkram";
            this.Load += new System.EventHandler(this.RukaiyaAkram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label txt_rollNo;
        private System.Windows.Forms.Label cmb_degree;
        private System.Windows.Forms.Label cmb_semester;
        private System.Windows.Forms.TextBox txtcoursetitle;
        private System.Windows.Forms.TextBox txtobtainmarks;
        private System.Windows.Forms.TextBox txtcoursecode;
        private System.Windows.Forms.ComboBox cmbgrade;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label txt_gpa;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

