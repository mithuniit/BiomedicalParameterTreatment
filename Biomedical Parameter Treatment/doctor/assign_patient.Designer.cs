namespace Biomedical_Parameter_Treatment.doctor
{
    partial class assign_patient
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.search_patientB = new System.Windows.Forms.Button();
            this.search_patientTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.search_doctorB = new System.Windows.Forms.Button();
            this.search_doctorTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Patient = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.patientidL = new System.Windows.Forms.Label();
            this.doctoridL = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cancelB = new System.Windows.Forms.Button();
            this.assignB = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nameL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 60);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biomedical parameter Treatment";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(13, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 219);
            this.panel3.TabIndex = 5;
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
            this.dataGridView1.Size = new System.Drawing.Size(453, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.search_patientB);
            this.panel2.Controls.Add(this.search_patientTB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 68);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(58, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Note: search anthing with your keyword.";
            // 
            // search_patientB
            // 
            this.search_patientB.Location = new System.Drawing.Point(350, 13);
            this.search_patientB.Name = "search_patientB";
            this.search_patientB.Size = new System.Drawing.Size(75, 23);
            this.search_patientB.TabIndex = 2;
            this.search_patientB.Text = "Search";
            this.search_patientB.UseVisualStyleBackColor = true;
            this.search_patientB.Click += new System.EventHandler(this.search_patientB_Click);
            // 
            // search_patientTB
            // 
            this.search_patientTB.Location = new System.Drawing.Point(58, 16);
            this.search_patientTB.Name = "search_patientTB";
            this.search_patientTB.Size = new System.Drawing.Size(286, 20);
            this.search_patientTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Location = new System.Drawing.Point(473, 262);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(453, 219);
            this.panel4.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(453, 219);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.search_doctorB);
            this.panel5.Controls.Add(this.search_doctorTB);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(472, 187);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(454, 68);
            this.panel5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(58, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Note: search anthing with your keyword.";
            // 
            // search_doctorB
            // 
            this.search_doctorB.Location = new System.Drawing.Point(350, 13);
            this.search_doctorB.Name = "search_doctorB";
            this.search_doctorB.Size = new System.Drawing.Size(75, 23);
            this.search_doctorB.TabIndex = 2;
            this.search_doctorB.Text = "Search";
            this.search_doctorB.UseVisualStyleBackColor = true;
            this.search_doctorB.Click += new System.EventHandler(this.search_doctorB_Click);
            // 
            // search_doctorTB
            // 
            this.search_doctorTB.Location = new System.Drawing.Point(58, 16);
            this.search_doctorTB.Name = "search_doctorTB";
            this.search_doctorTB.Size = new System.Drawing.Size(286, 20);
            this.search_doctorTB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search";
            // 
            // Patient
            // 
            this.Patient.AutoSize = true;
            this.Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient.Location = new System.Drawing.Point(189, 148);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(66, 24);
            this.Patient.TabIndex = 8;
            this.Patient.Text = "Patient";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(651, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Doctor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Patient ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Doctor ID";
            // 
            // patientidL
            // 
            this.patientidL.AutoSize = true;
            this.patientidL.Location = new System.Drawing.Point(135, 488);
            this.patientidL.Name = "patientidL";
            this.patientidL.Size = new System.Drawing.Size(0, 13);
            this.patientidL.TabIndex = 12;
            // 
            // doctoridL
            // 
            this.doctoridL.AutoSize = true;
            this.doctoridL.Location = new System.Drawing.Point(599, 488);
            this.doctoridL.Name = "doctoridL";
            this.doctoridL.Size = new System.Drawing.Size(0, 13);
            this.doctoridL.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cancelB);
            this.panel6.Controls.Add(this.assignB);
            this.panel6.Location = new System.Drawing.Point(13, 504);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(912, 54);
            this.panel6.TabIndex = 14;
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(728, 13);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 1;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // assignB
            // 
            this.assignB.Location = new System.Drawing.Point(641, 13);
            this.assignB.Name = "assignB";
            this.assignB.Size = new System.Drawing.Size(75, 23);
            this.assignB.TabIndex = 0;
            this.assignB.Text = "Assign";
            this.assignB.UseVisualStyleBackColor = true;
            this.assignB.Click += new System.EventHandler(this.assignB_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.nameL);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(12, 78);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(914, 31);
            this.panel7.TabIndex = 19;
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(403, 9);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(41, 13);
            this.nameL.TabIndex = 3;
            this.nameL.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // assign_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 550);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.doctoridL);
            this.Controls.Add(this.patientidL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Patient);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "assign_patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "assign_patient";
            this.Load += new System.EventHandler(this.assign_patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search_patientB;
        private System.Windows.Forms.TextBox search_patientTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button search_doctorB;
        private System.Windows.Forms.TextBox search_doctorTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Patient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label patientidL;
        private System.Windows.Forms.Label doctoridL;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button assignB;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label label11;
    }
}