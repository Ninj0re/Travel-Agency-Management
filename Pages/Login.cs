using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAMS.Pages;

namespace TAMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email, password;

            email = txt_email.Text;
            password = txt_password.Text;

            try
            {
                String querry = "Select * from Tourists where Email = '"+txt_email.Text+"' AND tourist_password = '"+txt_password.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, Program.connect);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    email = txt_email.Text;
                    password = txt_password.Text;
                    //page that needed to be load next


                      this.Hide();
                      new Reserve().Show();
                }
                else
                {
                    MessageBox.Show("Invalid login details"
                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_email.Clear();
                    txt_password.Clear();

                    //to focus username
                    txt_email.Focus();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Error: " + hata.Message);
            }
            finally
            {
                Program.connect.Close();
            }


    }

    private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Signup().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
