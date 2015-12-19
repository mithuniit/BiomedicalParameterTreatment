namespace Biomedical_Parameter_Treatment.doctor
{
    partial class edit_patient
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.searchB = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sexCB = new System.Windows.Forms.ComboBox();
            this.browseB = new System.Windows.Forms.Button();
            this.browseTB = new System.Windows.Forms.TextBox();
            this.attachment_picPB = new System.Windows.Forms.PictureBox();
            this.diseaseTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pidTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cancelB = new System.Windows.Forms.Button();
            this.saveB = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachment_picPB)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(13, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 140);
            this.panel3.TabIndex = 32;
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
            this.dataGridView1.Size = new System.Drawing.Size(841, 140);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.searchB);
            this.panel2.Controls.Add(this.searchTB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 68);
            this.panel2.TabIndex = 31;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 60);
            this.panel1.TabIndex = 30;
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
            // sexCB
            // 
            this.sexCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexCB.FormattingEnabled = true;
            this.sexCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexCB.Location = new System.Drawing.Point(156, 464);
            this.sexCB.Name = "sexCB";
            this.sexCB.Size = new System.Drawing.Size(121, 21);
            this.sexCB.TabIndex = 60;
            this.sexCB.UseWaitCursor = true;
            // 
            // browseB
            // 
            this.browseB.Location = new System.Drawing.Point(561, 532);
            this.browseB.Name = "browseB";
            this.browseB.Size = new System.Drawing.Size(75, 23);
            this.browseB.TabIndex = 59;
            this.browseB.Text = "Browse";
            this.browseB.UseVisualStyleBackColor = true;
            this.browseB.UseWaitCursor = true;
            this.browseB.Click += new System.EventHandler(this.browseB_Click);
            // 
            // browseTB
            // 
            this.browseTB.Enabled = false;
            this.browseTB.Location = new System.Drawing.Point(421, 535);
            this.browseTB.Name = "browseTB";
            this.browseTB.Size = new System.Drawing.Size(134, 20);
            this.browseTB.TabIndex = 58;
            this.browseTB.UseWaitCursor = true;
            // 
            // attachment_picPB
            // 
            this.attachment_picPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attachment_picPB.Location = new System.Drawing.Point(420, 339);
            this.attachment_picPB.Name = "attachment_picPB";
            this.attachment_picPB.Size = new System.Drawing.Size(216, 181);
            this.attachment_picPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.attachment_picPB.TabIndex = 57;
            this.attachment_picPB.TabStop = false;
            this.attachment_picPB.UseWaitCursor = true;
            // 
            // diseaseTB
            // 
            this.diseaseTB.Location = new System.Drawing.Point(156, 541);
            this.diseaseTB.Multiline = true;
            this.diseaseTB.Name = "diseaseTB";
            this.diseaseTB.Size = new System.Drawing.Size(229, 56);
            this.diseaseTB.TabIndex = 56;
            this.diseaseTB.UseWaitCursor = true;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(156, 504);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(229, 20);
            this.phoneTB.TabIndex = 55;
            this.phoneTB.UseWaitCursor = true;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(156, 438);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(127, 20);
            this.ageTB.TabIndex = 54;
            this.ageTB.UseWaitCursor = true;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(156, 371);
            this.addressTB.Multiline = true;
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(229, 56);
            this.addressTB.TabIndex = 53;
            this.addressTB.UseWaitCursor = true;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(156, 339);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(229, 20);
            this.nameTB.TabIndex = 52;
            this.nameTB.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Disease";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Phone";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Sex";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Age";
            this.label4.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Address";
            this.label8.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Name";
            this.label9.UseWaitCursor = true;
            // 
            // pidTB
            // 
            this.pidTB.Enabled = false;
            this.pidTB.Location = new System.Drawing.Point(156, 309);
            this.pidTB.Name = "pidTB";
            this.pidTB.Size = new System.Drawing.Size(229, 20);
            this.pidTB.TabIndex = 62;
            this.pidTB.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Patient ID";
            this.label10.UseWaitCursor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cancelB);
            this.panel4.Controls.Add(this.saveB);
            this.panel4.Location = new System.Drawing.Point(86, 640);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(613, 56);
            this.panel4.TabIndex = 63;
            this.panel4.UseWaitCursor = true;
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(486, 16);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 1;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.UseWaitCursor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // saveB
            // 
            this.saveB.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.saveB.Location = new System.Drawing.Point(396, 16);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(75, 23);
            this.saveB.TabIndex = 0;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.UseWaitCursor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // edit_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 708);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pidTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sexCB);
            this.Controls.Add(this.browseB);
            this.Controls.Add(this.browseTB);
            this.Controls.Add(this.attachment_picPB);
            this.Controls.Add(this.diseaseTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "edit_patient";
            this.Text = "edit_patient";
            this.Load += new System.EventHandler(this.edit_patient_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachment_picPB)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sexCB;
        private System.Windows.Forms.Button browseB;
        private System.Windows.Forms.TextBox browseTB;
        private System.Windows.Forms.PictureBox attachment_picPB;
        private System.Windows.Forms.TextBox diseaseTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pidTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button saveB;
    }
}