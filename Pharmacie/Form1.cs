using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
            //string conx = @"Data Source=MAMOUNY078\SQLEXPRESS;Initial Catalog=pharmacie;Integrated Security=True";
            //btn_Submit Click event
            if(user_text.Text=="" || pass_text.Text=="")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection

                SqlConnection con = Connexion.openConnection();
                SqlCommand cmd = new SqlCommand("Select * from users where username=@username and password=@password",con);
                cmd.Parameters.AddWithValue("@username",user_text.Text);
                cmd.Parameters.AddWithValue("@password", pass_text.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    this.Hide();
                    Home fm = new Home();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Username or password Failed!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
