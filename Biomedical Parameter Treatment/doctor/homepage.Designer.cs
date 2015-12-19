namespace Biomedical_Parameter_Treatment.doctor
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edit_patientB = new System.Windows.Forms.Button();
            this.add_patientB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.treatment = new System.Windows.Forms.Button();
            this.show_patientB = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.assign_patientB = new System.Windows.Forms.Button();
            this.logoutB = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.doctoridL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 44);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biomedical parameter Treatment";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(772, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(409, 17);
            this.toolStripStatusLabel1.Text = "Developed By: Institute of Information Technology, Jahangirnagar University";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.edit_patientB);
            this.panel2.Controls.Add(this.add_patientB);
            this.panel2.Location = new System.Drawing.Point(36, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 171);
            this.panel2.TabIndex = 18;
            // 
            // edit_patientB
            // 
            this.edit_patientB.Location = new System.Drawing.Point(13, 94);
            this.edit_patientB.Name = "edit_patientB";
            this.edit_patientB.Size = new System.Drawing.Size(169, 38);
            this.edit_patientB.TabIndex = 1;
            this.edit_patientB.Text = "Edit patient";
            this.edit_patientB.UseVisualStyleBackColor = true;
            this.edit_patientB.Click += new System.EventHandler(this.edit_patientB_Click);
            // 
            // add_patientB
            // 
            this.add_patientB.Location = new System.Drawing.Point(13, 15);
            this.add_patientB.Name = "add_patientB";
            this.add_patientB.Size = new System.Drawing.Size(169, 37);
            this.add_patientB.TabIndex = 0;
            this.add_patientB.Text = "Add a New patient";
            this.add_patientB.UseVisualStyleBackColor = true;
            this.add_patientB.Click += new System.EventHandler(this.add_patientB_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.treatment);
            this.panel3.Controls.Add(this.show_patientB);
            this.panel3.Location = new System.Drawing.Point(525, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 171);
            this.panel3.TabIndex = 19;
            // 
            // treatment
            // 
            this.treatment.Location = new System.Drawing.Point(29, 83);
            this.treatment.Name = "treatment";
            this.treatment.Size = new System.Drawing.Size(169, 41);
            this.treatment.TabIndex = 1;
            this.treatment.Text = "Show Recieving Patient Information && Treatment";
            this.treatment.UseVisualStyleBackColor = true;
            this.treatment.Click += new System.EventHandler(this.treatment_Click);
            // 
            // show_patientB
            // 
            this.show_patientB.Location = new System.Drawing.Point(29, 11);
            this.show_patientB.Name = "show_patientB";
            this.show_patientB.Size = new System.Drawing.Size(169, 41);
            this.show_patientB.TabIndex = 0;
            this.show_patientB.Text = "Show Sending Patient Information && Treatment";
            this.show_patientB.UseVisualStyleBackColor = true;
            this.show_patientB.Click += new System.EventHandler(this.show_patientB_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.assign_patientB);
            this.panel4.Location = new System.Drawing.Point(269, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 171);
            this.panel4.TabIndex = 20;
            // 
            // assign_patientB
            // 
            this.assign_patientB.Location = new System.Drawing.Point(13, 54);
            this.assign_patientB.Name = "assign_patientB";
            this.assign_patientB.Size = new System.Drawing.Size(202, 38);
            this.assign_patientB.TabIndex = 0;
            this.assign_patientB.Text = "Assign patient to Doctor";
            this.assign_patientB.UseVisualStyleBackColor = true;
            this.assign_patientB.Click += new System.EventHandler(this.assign_patientB_Click);
            // 
            // logoutB
            // 
            this.logoutB.Location = new System.Drawing.Point(604, 7);
            this.logoutB.Name = "logoutB";
            this.logoutB.Size = new System.Drawing.Size(98, 23);
            this.logoutB.TabIndex = 1;
            this.logoutB.Text = "Logout";
            this.logoutB.UseVisualStyleBackColor = true;
            this.logoutB.Click += new System.EventHandler(this.logoutB_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.nameL);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.doctoridL);
            this.panel5.Controls.Add(this.logoutB);
            this.panel5.Location = new System.Drawing.Point(12, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(756, 41);
            this.panel5.TabIndex = 21;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // doctoridL
            // 
            this.doctoridL.AutoSize = true;
            this.doctoridL.Location = new System.Drawing.Point(34, 12);
            this.doctoridL.Name = "doctoridL";
            this.doctoridL.Size = new System.Drawing.Size(21, 13);
            this.doctoridL.TabIndex = 2;
            this.doctoridL.Text = " ID";
            this.doctoridL.Click += new System.EventHandler(this.doctoridL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(361, 12);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(35, 13);
            this.nameL.TabIndex = 4;
            this.nameL.Text = "label3";
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(772, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homepage";
            this.Load += new System.EventHandler(this.homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button edit_patientB;
        private System.Windows.Forms.Button add_patientB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button show_patientB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button assign_patientB;
        private System.Windows.Forms.Button logoutB;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label doctoridL;
        private System.Windows.Forms.Button treatment;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label label2;
    }
}