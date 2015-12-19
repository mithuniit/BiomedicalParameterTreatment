using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Biomedical_Parameter_Treatment.doctor
{
    public partial class edit_patient : Form
    {
        Database.dbConnect dbo = new Database.dbConnect();
        Database.information_load il = new Database.information_load();
        public int doctorid;
        public edit_patient()
        {
            InitializeComponent();
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            String sql = "";
            string search_value = searchTB.Text;

            if (searchTB.Text == "")
                sql = "SELECT `p_id`, `p_name`, `p_address`, `p_age`, `p_sex`, `p_phone`, `p_disease_info` FROM `patient` WHERE `added_by` =" + doctorid ;
            else
                sql = "SELECT `p_id`, `p_name`, `p_address`, `p_age`, `p_sex`, `p_phone`, `p_disease_info` FROM `patient` WHERE `added_by`=" + doctorid + " and `p_name` LIKE '%" + search_value + "%' OR `p_address` LIKE '%" + search_value + "%'";

            il.datagridview_load(sql, dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            pidTB.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            nameTB.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            addressTB.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            ageTB .Text = dataGridView1[3, e.RowIndex].Value.ToString();
            sexCB.SelectedItem = dataGridView1[4, e.RowIndex].Value.ToString();
            phoneTB.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            diseaseTB.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            String file_path = Application.StartupPath + "\\disease_image\\" + pidTB.Text + ".jpg";
            attachment_picPB.ImageLocation = file_path;
            
            
        }

        private void edit_patient_Load(object sender, EventArgs e)
        {

        }

        private void browseB_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp) | *.jpg; *.jpeg; *.gif; *.bmp";

            if (result == DialogResult.OK)
            {


                browseTB.Text = openFileDialog1.FileName;
                FileInfo fi = new FileInfo(openFileDialog1.FileName);
                long fileSize = fi.Length / 1000;//in KB
                // fileSIzeL.Text = fileSize.ToString() + " KB";

                if (fileSize < 2000)
                {
                    attachment_picPB.Image = new Bitmap(openFileDialog1.FileName);
                    attachment_picPB.ImageLocation = openFileDialog1.FileName;
                    // stampSizePB.Image = new Bitmap(openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("This FileSize is " + fileSize + " KB. Filesize should be less than 2 MB.");
                }

            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            if (nameTB.Text == "" || ageTB.Text == "" || phoneTB.Text == "" || diseaseTB.Text == "")
            {
                MessageBox.Show("Fill up the information.");
                return;
            }

            string sql = "UPDATE `patient` SET `p_name` = '"+nameTB.Text+"',`p_address` = '"+addressTB.Text+"',`p_sex` = '"+sexCB.SelectedItem+"',`p_phone` = '"+phoneTB.Text+"',`p_disease_info` = '"+diseaseTB.Text+"',`added_by` = '"+doctorid+"' WHERE `patient`.`p_id` ="+pidTB.Text+";";
            dbo.Update(sql);
            


            try
            {

                string picid = dbo.single_value(" SELECT max(p_id) FROM patient");
                string extension = System.IO.Path.GetExtension(openFileDialog1.FileName);
                //attachment_picPB.ImageLocation = openFileDialog1.FileName;
                string FilePath = Application.StartupPath + "\\disease_image\\" + picid + extension;

                // attachment_picPB.Image.Save(FilePath);
                File.Copy(browseTB.Text, FilePath,true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
