using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biomedical_Parameter_Treatment.doctor
{
    public partial class homepage : Form
    {
        public int doctor_id ;
        public string name;
        public homepage()
        {
            InitializeComponent();
        }

        private void add_patientB_Click(object sender, EventArgs e)
        {
            //this.Visible = true;
            add_patient aa = new add_patient();
            aa.doctorid = this.doctor_id;
            aa.name = this.name;
            aa.Visible = true;

        }

        private void logoutB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 ss = new Form1();
            ss.Visible = true;
        }

        private void show_patientB_Click(object sender, EventArgs e)
        {
            show_patient sp = new show_patient();
            sp.doctorid = this.doctor_id;
            sp.Visible = true;

        }

        private void homepage_Load(object sender, EventArgs e)
        {
            doctoridL.Text = "ID: " + doctor_id;
            doctoridL.Visible = false;
            nameL.Text = ""+name;
        }

        private void assign_patientB_Click(object sender, EventArgs e)
        {
            assign_patient ap = new assign_patient();
            ap.doctorid = this.doctor_id;
            ap.name = this.name; 
            ap.Visible = true;

        }

        private void treatment_Click(object sender, EventArgs e)
        {
            treatment tt = new treatment();
            tt.doctorid = this.doctor_id;
            tt.name = this.name;
            tt.Visible = true;
        }

        private void edit_patientB_Click(object sender, EventArgs e)
        {
            edit_patient ep = new edit_patient();
            ep.doctorid = this.doctor_id;
            ep.Visible = true;

        }

        private void doctoridL_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
