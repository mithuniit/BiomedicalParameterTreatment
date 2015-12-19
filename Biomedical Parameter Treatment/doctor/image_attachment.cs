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
    public partial class image_attachment : Form
    {

        public int picid;
        public image_attachment()
        {
            InitializeComponent();
        }

        private void image_attachment_Load(object sender, EventArgs e)
        {

            try
            {
                String file_path = Application.StartupPath + "\\disease_image\\" + picid + ".jpg";
                pictureBox1.ImageLocation = file_path;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
