namespace WindowsFormsApp1
{
    partial class Tests
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.testlist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.testcost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.testname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.diagbtn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Testbtn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patbtn = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.logoutbtn = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testlist)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Testbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(177, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 543);
            this.panel2.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.testlist);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(15, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1071, 326);
            this.panel4.TabIndex = 1;
            // 
            // testlist
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.testlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.testlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.testlist.ColumnHeadersHeight = 20;
            this.testlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.testlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.testlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.testlist.Location = new System.Drawing.Point(14, 48);
            this.testlist.Name = "testlist";
            this.testlist.RowHeadersVisible = false;
            this.testlist.RowHeadersWidth = 51;
            this.testlist.RowTemplate.Height = 26;
            this.testlist.Size = new System.Drawing.Size(1043, 260);
            this.testlist.TabIndex = 13;
            this.testlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.testlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.testlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.testlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.testlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.testlist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.testlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.testlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.testlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.testlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.testlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.testlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.testlist.ThemeStyle.HeaderStyle.Height = 20;
            this.testlist.ThemeStyle.ReadOnly = false;
            this.testlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.testlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.testlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.testlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.testlist.ThemeStyle.RowsStyle.Height = 26;
            this.testlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.testlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.testlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.testlist_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(421, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 32);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tests List";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.deletebtn);
            this.panel3.Controls.Add(this.updatebtn);
            this.panel3.Controls.Add(this.savebtn);
            this.panel3.Controls.Add(this.testcost);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.testname);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(14, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1072, 183);
            this.panel3.TabIndex = 0;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Coral;
            this.deletebtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(515, 134);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(105, 44);
            this.deletebtn.TabIndex = 22;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.CadetBlue;
            this.updatebtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(515, 80);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(105, 44);
            this.updatebtn.TabIndex = 21;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.savebtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(515, 23);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(105, 44);
            this.savebtn.TabIndex = 20;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // testcost
            // 
            this.testcost.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testcost.Location = new System.Drawing.Point(20, 141);
            this.testcost.Name = "testcost";
            this.testcost.Size = new System.Drawing.Size(282, 34);
            this.testcost.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SlateGray;
            this.label9.Location = new System.Drawing.Point(15, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Test Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(10, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 33);
            this.label7.TabIndex = 11;
            this.label7.Text = "Manage Patients";
            // 
            // testname
            // 
            this.testname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testname.Location = new System.Drawing.Point(20, 70);
            this.testname.Name = "testname";
            this.testname.Size = new System.Drawing.Size(282, 34);
            this.testname.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SlateGray;
            this.label6.Location = new System.Drawing.Point(15, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Test Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(550, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "Health Care M.System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.diagbtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Testbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.patbtn);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 521);
            this.panel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(8, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dashboard";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.web_analysis;
            this.pictureBox4.Location = new System.Drawing.Point(18, 373);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(14, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Diagnosis";
            // 
            // diagbtn
            // 
            this.diagbtn.Image = global::WindowsFormsApp1.Properties.Resources.diagnosis;
            this.diagbtn.Location = new System.Drawing.Point(18, 250);
            this.diagbtn.Name = "diagbtn";
            this.diagbtn.Size = new System.Drawing.Size(90, 65);
            this.diagbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diagbtn.TabIndex = 7;
            this.diagbtn.TabStop = false;
            this.diagbtn.Click += new System.EventHandler(this.diagbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(32, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tests";
            // 
            // Testbtn
            // 
            this.Testbtn.Image = global::WindowsFormsApp1.Properties.Resources.chemistry;
            this.Testbtn.Location = new System.Drawing.Point(18, 134);
            this.Testbtn.Name = "Testbtn";
            this.Testbtn.Size = new System.Drawing.Size(90, 65);
            this.Testbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Testbtn.TabIndex = 5;
            this.Testbtn.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patients";
            // 
            // patbtn
            // 
            this.patbtn.Image = global::WindowsFormsApp1.Properties.Resources.patient;
            this.patbtn.Location = new System.Drawing.Point(19, 13);
            this.patbtn.Name = "patbtn";
            this.patbtn.Size = new System.Drawing.Size(90, 65);
            this.patbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patbtn.TabIndex = 3;
            this.patbtn.TabStop = false;
            this.patbtn.Click += new System.EventHandler(this.patbtn_Click);
            // 
            // close
            // 
            this.close.Image = global::WindowsFormsApp1.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(1264, 14);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(38, 25);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 18;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Image = global::WindowsFormsApp1.Properties.Resources.logout;
            this.logoutbtn.Location = new System.Drawing.Point(49, 23);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(57, 43);
            this.logoutbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutbtn.TabIndex = 16;
            this.logoutbtn.TabStop = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 626);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tests";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testlist)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Testbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView testlist;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox testcost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox testname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox logoutbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox diagbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Testbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox patbtn;
    }
}