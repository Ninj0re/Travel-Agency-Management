using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //I wrote that line for connect database


namespace TAMS
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        try 
        { 
            if(Program.connect.State == ConnectionState.Closed)
            {
                Program.connect.Open();
            }
                string kayit = "insert into tourists(SSN,FirstName,Surname,Birthdate,Email,Gender,tourist_password) values(@ssn,@firstname,@surname,@birthdate,@email,@gender,@touristpassword )";

                SqlCommand komut = new SqlCommand(kayit, Program.connect);
                
                komut.Parameters.AddWithValue("@ssn", txt_ssn.Text);
                komut.Parameters.AddWithValue("@firstname", txt_fn.Text);
                komut.Parameters.AddWithValue("@surname", txt_sn.Text);
                komut.Parameters.AddWithValue("@birthdate", txt_bd.Text);
                komut.Parameters.AddWithValue("@email", txt_email.Text);
                komut.Parameters.AddWithValue("@gender", "M");
                komut.Parameters.AddWithValue("@touristpassword", txt_tpassword.Text);
                
                komut.ExecuteNonQuery();
                Program.connect.Close();
                
                MessageBox.Show("You have successfuly created an account.");
                
                this.Hide();
                new Login().Show();

        }
            catch(Exception hata) 
            {
                MessageBox.Show("Hata meydana geldi" + hata.Message);
            }
            finally { Program.connect.Close(); }
 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            txt_ssn.MaxLength = 9;
            txt_bd.Format = DateTimePickerFormat.Custom;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        // Setted max legth of 9 and only numbers for SSN
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_fn_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_bd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
