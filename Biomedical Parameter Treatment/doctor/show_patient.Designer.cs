namespace Biomedical_Parameter_Treatment.doctor
{
    partial class show_patient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.searchB = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pidTB = new System.Windows.Forms.TextBox();
            this.paidTB = new System.Windows.Forms.TextBox();
            this.pnameTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.sexTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.diseaseTB = new System.Windows.Forms.TextBox();
            this.medicineTB = new System.Windows.Forms.TextBox();
            this.adviceTB = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dnameTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(197, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 60);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biomedical parameter Treatment";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.searchB);
            this.panel2.Controls.Add(this.searchTB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(199, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 68);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(186, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Note: search anthing with your keyword.";
            // 
            // searchB
            // 
            this.searchB.Location = new System.Drawing.Point(478, 19);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(75, 23);
            this.searchB.TabIndex = 2;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(186, 22);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(286, 20);
            this.searchTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(199, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 219);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(841, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 663);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Prescription";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 663);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prescription Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Patient Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Patient Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 594);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 604);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sex";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 563);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Age";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(443, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Disease";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(443, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Medicine";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(443, 621);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Advice";
            // 
            // pidTB
            // 
            this.pidTB.Location = new System.Drawing.Point(203, 399);
            this.pidTB.Name = "pidTB";
            this.pidTB.Size = new System.Drawing.Size(180, 20);
            this.pidTB.TabIndex = 16;
            // 
            // paidTB
            // 
            this.paidTB.Location = new System.Drawing.Point(203, 481);
            this.paidTB.Name = "paidTB";
            this.paidTB.Size = new System.Drawing.Size(180, 20);
            this.paidTB.TabIndex = 17;
            // 
            // pnameTB
            // 
            this.pnameTB.Location = new System.Drawing.Point(203, 516);
            this.pnameTB.Name = "pnameTB";
            this.pnameTB.Size = new System.Drawing.Size(180, 20);
            this.pnameTB.TabIndex = 18;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(203, 560);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(180, 20);
            this.ageTB.TabIndex = 19;
            // 
            // sexTB
            // 
            this.sexTB.Location = new System.Drawing.Point(203, 601);
            this.sexTB.Name = "sexTB";
            this.sexTB.Size = new System.Drawing.Size(180, 20);
            this.sexTB.TabIndex = 20;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(540, 399);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(212, 20);
            this.phoneTB.TabIndex = 21;
            // 
            // diseaseTB
            // 
            this.diseaseTB.Location = new System.Drawing.Point(540, 440);
            this.diseaseTB.Name = "diseaseTB";
            this.diseaseTB.Size = new System.Drawing.Size(212, 20);
            this.diseaseTB.TabIndex = 22;
            // 
            // medicineTB
            // 
            this.medicineTB.Location = new System.Drawing.Point(540, 484);
            this.medicineTB.Multiline = true;
            this.medicineTB.Name = "medicineTB";
            this.medicineTB.Size = new System.Drawing.Size(212, 107);
            this.medicineTB.TabIndex = 23;
            // 
            // adviceTB
            // 
            this.adviceTB.Location = new System.Drawing.Point(540, 623);
            this.adviceTB.Multiline = true;
            this.adviceTB.Name = "adviceTB";
            this.adviceTB.Size = new System.Drawing.Size(212, 63);
            this.adviceTB.TabIndex = 24;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Biomedical_Parameter_Treatment.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(770, 415);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(472, 289);
            this.reportViewer1.TabIndex = 25;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dnameTB
            // 
            this.dnameTB.Location = new System.Drawing.Point(203, 439);
            this.dnameTB.Name = "dnameTB";
            this.dnameTB.Size = new System.Drawing.Size(177, 20);
            this.dnameTB.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(110, 442);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Doctor Name:";
            // 
            // show_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dnameTB);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.adviceTB);
            this.Controls.Add(this.medicineTB);
            this.Controls.Add(this.diseaseTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.sexTB);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.pnameTB);
            this.Controls.Add(this.paidTB);
            this.Controls.Add(this.pidTB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "show_patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "show_patient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.show_patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox pidTB;
        private System.Windows.Forms.TextBox paidTB;
        private System.Windows.Forms.TextBox pnameTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox sexTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox diseaseTB;
        private System.Windows.Forms.TextBox medicineTB;
        private System.Windows.Forms.TextBox adviceTB;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox dnameTB;
        private System.Windows.Forms.Label label14;
    }
}