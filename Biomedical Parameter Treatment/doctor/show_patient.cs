using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace Biomedical_Parameter_Treatment.doctor
{


    public partial class show_patient : Form
    {
        Database.information_load il = new Database.information_load();
        public int doctorid;
        public show_patient()
        {
            InitializeComponent();

        }

        private void show_patient_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

        }



     
       

        private void searchB_Click(object sender, EventArgs e)
        {
            String sql = "";
            string search_value= searchTB.Text;

            if (searchTB.Text == "")
                sql = "SELECT ps.pres_id,p.`p_id`,p.p_name,p.p_age,p.`p_phone`,p.`p_sex`,p.`p_disease_info`,ps.`medicine_info`,ps.`advice`,`dname` FROM `prescription` as ps,`patient` as p WHERE `remote_d_id` =" + doctorid + " and p.p_id = ps . p_id";
            else
                sql = "SELECT ps.pres_id,p.`p_id`,p.p_name,p.p_age,p.`p_phone`,p.`p_sex`,p.`p_disease_info`,ps.`medicine_info`,ps.`advice`,`dname` FROM `prescription` as ps,`patient` as p WHERE `remote_d_id` =" + doctorid + " and p.p_id = ps . p_id  and  p.`p_name` LIKE '%" + search_value + "%' OR p.`p_address` LIKE '%" + search_value + "%'";
            
            il.datagridview_load(sql, dataGridView1);


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            pidTB.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            paidTB.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            pnameTB.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            ageTB.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            sexTB.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            phoneTB.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            diseaseTB.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            medicineTB.Text = dataGridView1[7, e.RowIndex].Value.ToString();
            adviceTB.Text = dataGridView1[8, e.RowIndex].Value.ToString();
            dnameTB.Text = dataGridView1[9, e.RowIndex].Value.ToString();
        }

           


        private void button1_Click(object sender, EventArgs e)
        {
            string pid = pidTB.Text;
            string paid = paidTB.Text;
            string name= pnameTB.Text;
            string age=ageTB.Text;
            string sex= sexTB.Text;
            string phone=phoneTB.Text;
            string disease=diseaseTB.Text;
            string medicine=medicineTB.Text;
            string advice = adviceTB.Text;
            string dname = dnameTB.Text;
           



            List<ReportParameter> rptPara = new List<ReportParameter>();
            rptPara.Add(new ReportParameter("pid",pid));
            rptPara.Add(new ReportParameter("paid", paid));
            rptPara.Add(new ReportParameter("name", name));
            rptPara.Add(new ReportParameter("age", age));
            rptPara.Add(new ReportParameter("sex", sex));
            rptPara.Add(new ReportParameter("phone", phone));
            rptPara.Add(new ReportParameter("disease", disease));
            rptPara.Add(new ReportParameter("medicine", medicine));
            rptPara.Add(new ReportParameter("advice", advice));
            rptPara.Add(new ReportParameter("dname", dname));







            reportViewer1.LocalReport.SetParameters(rptPara);
            this.reportViewer1.RefreshReport();

           /* Warning[] warnings;

            string[] streamids;

            string mimeType;

            string encoding;

            string extension;



            byte[] bytes = reportViewer1.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension,out streamids, out warnings);

            

            FileStream fs = new FileStream(@"D:\ReportOutput.pdf", FileMode.Create);

            fs.Write(bytes, 0, bytes.Length);

            fs.Close();*/


           


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
