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
    public partial class assign_patient : Form
    {
        Database.dbConnect dbo = new Database.dbConnect();
        Database.information_load il = new Database.information_load();
        public int doctorid;
        public string name;
        public assign_patient()
        {
            InitializeComponent();
        }

        private void search_patientB_Click(object sender, EventArgs e)
        {
            String sql = "";
            string search_value = search_patientTB.Text;

            if (search_value == "")
                sql = "SELECT `p_id`, `p_name`, `p_address`, `p_age`, `p_sex`, `p_phone`, `p_disease_info` FROM `patient`";
            else
                sql = "SELECT `p_id`, `p_name`, `p_address`, `p_age`, `p_sex`, `p_phone`, `p_disease_info` FROM `patient` WHERE  `p_name` LIKE '%" + search_value + "%' OR `p_address` LIKE '%" + search_value + "%'";

            il.datagridview_load(sql, dataGridView1);
        }

        private void search_doctorB_Click(object sender, EventArgs e)
        {
            String sql2 = "";
            string search_value = search_doctorTB.Text;

            if (search_value == "")
                sql2 = "SELECT `d_id`, `d_name`, `d_designation`, `d_hospital`, `d_phone`, `d_email`, `d_username`  FROM `doctor`";
            else
                sql2 = "SELECT `d_id`, `d_name`, `d_designation`, `d_hospital`, `d_phone`, `d_email`, `d_username`  FROM `doctor` WHERE `d_name` LIKE '%" + search_value + "%' OR `d_designation` LIKE '%" + search_value + "%' OR `d_hospital` LIKE '%" + search_value + "%' OR `d_phone` LIKE '%" + search_value + "%' OR `d_email` LIKE '%" + search_value + "%' OR `d_username` LIKE '%" + search_value + "%'";

            il.datagridview_load(sql2, dataGridView2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            patientidL.Text = dataGridView1[0, e.RowIndex].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            doctoridL.Text = dataGridView2[0, e.RowIndex].Value.ToString();
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void assignB_Click(object sender, EventArgs e)
        {
            if (patientidL.Text == "" || doctoridL.Text == "") {
                MessageBox.Show("Select at least one patient and one doctor. try again.");
                return;


            }

            string query = "INSERT INTO `biomedical`.`prescription` (`pres_id`, `p_id`, `d_id`, `medicine_info`, `advice`, `remote_d_id`, `date_time`) VALUES (NULL, '" + patientidL.Text + "', '" + doctoridL.Text + "', '', '', '" + doctorid + "', CURRENT_TIMESTAMP);";
            dbo.Insert(query);

        }

        private void assign_patient_Load(object sender, EventArgs e)
        {
           //doctoridL.Text = "Doctor ID: " + doctorid;
            label10.Text = doctorid.ToString();
            label10.Visible = false;
            nameL.Text = name.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
