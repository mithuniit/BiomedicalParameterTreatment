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
    public partial class add_patient : Form
    {
       
        Database.dbConnect dbo = new Database.dbConnect();
        public int doctorid;
        public string name;
        public add_patient()
        {
            InitializeComponent();
        }

        private void add_patient_Load(object sender, EventArgs e)
        {
            sexCB.SelectedIndex = 0;
            doctoridL.Text = " " + doctorid;
            doctoridL.Visible = false;
            nameL.Text = ""+name;
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            if (nameTB.Text == "" || ageTB.Text == "" || phoneTB.Text == "" || diseaseTB.Text == "") {
                MessageBox.Show("Fill up the information.");
                return;
            }

            string sql = "INSERT INTO `biomedical`.`patient` (`p_id`, `p_name`, `p_address`, `p_age`, `p_sex`, `p_phone`, `p_disease_info`,`added_by`) VALUES (NULL, '"+nameTB.Text+"', '"+addressTB.Text+"', '"+ageTB.Text+"', '"+sexCB.SelectedItem.ToString()+"', '"+phoneTB.Text+"', '"+diseaseTB.Text+"','"+doctorid+"');";
            dbo.Insert(sql);
             string pid = dbo.single_value(" SELECT max(p_id) FROM patient");

            string query = "INSERT INTO `biomedical`.`prescription` (`pres_id`, `p_id`, `d_id`, `medicine_info`, `advice`, `remote_d_id`, `date_time`) VALUES (NULL, '"+pid+"', '"+doctorid+"', '', '', '"+doctorid+"', CURRENT_TIMESTAMP);";
            dbo.Insert(query);


            try
            {
                
                string picid = dbo.single_value(" SELECT max(p_id) FROM patient");
                string extension = System.IO.Path.GetExtension(openFileDialog1.FileName);
                //attachment_picPB.ImageLocation = openFileDialog1.FileName;
               string FilePath = Application.StartupPath + "\\disease_image\\" + picid + extension;

               // attachment_picPB.Image.Save(FilePath);
               File.Copy(browseTB.Text, FilePath);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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

        private void doctoridL_Click(object sender, EventArgs e)
        {

        }

        
       
    }
}
