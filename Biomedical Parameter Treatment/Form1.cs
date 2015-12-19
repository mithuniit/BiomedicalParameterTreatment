using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Windows.Forms;

namespace Biomedical_Parameter_Treatment
{
    public partial class Form1 : Form
    {

        Database.dbConnect dbo = new Database.dbConnect();
        MySqlConnection con = Database.dbConnect.Initialize();
        public Form1()
        {
            InitializeComponent();
        }

        private void signupB_Click(object sender, EventArgs e)
        {
            if (nameTB.Text == "" || hospitalTB.Text == "" || phoneTB.Text == "" || signup_usernameTB.Text=="" || signup_passwordTB.Text =="") {
                MessageBox.Show("Fill up the empty field");
                return;
            }

            string sql = "INSERT INTO `biomedical`.`doctor` (`d_id`, `d_name`, `d_designation`, `d_hospital`, `d_phone`, `d_email`, `d_username`, `d_password`) VALUES (NULL, '"+nameTB.Text+"', '"+designationTB.Text+"', '"+hospitalTB.Text+"', '"+phoneTB.Text+"', '"+emailTB.Text+"', '"+signup_usernameTB.Text+"', '"+signup_passwordTB.Text+"');";
            dbo.Insert(sql);

            nameTB.Text = "";
            designationTB.Text = "";
            hospitalTB.Text = "";
            phoneTB.Text = "";
            emailTB.Text = "";
            signup_usernameTB.Text = "";
            signup_passwordTB.Text = "";



        }

        private void loginB_Click(object sender, EventArgs e)
        {
            if (login_usernameTB.Text == "" || login_passwordTB.Text == "") {
                MessageBox.Show("Fill up required information");
                return;
            }

            con.Open();
            string query = "SELECT `d_id`,`d_name`,`d_username`, `d_password` FROM `doctor` WHERE `d_username`='"+login_usernameTB.Text+"' and `d_password`='"+login_passwordTB.Text+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                this.Visible = false;
                doctor.homepage hh = new doctor.homepage();
                hh.doctor_id = reader.GetInt32(0);
                hh.name= reader.GetString(1);
                hh.Visible = true;
            }
            else {

                MessageBox.Show("username/password incorrect."); 
                con.Close();
                return;
            }
            
            reader.Close();
            con.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

       
    }
}
