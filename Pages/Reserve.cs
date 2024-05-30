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

namespace TAMS.Pages
{
    public partial class Reserve : Form
    {
        const int NUMBER_OF_BUTTON_COLUMNS = 6;
        const int BUTTON_HEIGHT = 90;
        const int BUTTON_WIDTH = 200;
        const int BUTTON_MARGIN = 50;
        Login login;
        
        public Reserve(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reserve_Load(object sender, EventArgs e)
        {

        }

        private void My_reservations_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MyReservations(login).Show();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
       
        public void AddButtons()
        {
            String departureCity, arriwalCity, departureDate, arrivalDate;

            departureCity = Departure_city_txt.Text;
            arriwalCity = Arrival_city_txt.Text;

            try
            {
                
                String querry = "Select * from Tours where DepartureCity = ' " + departureCity + "' AND ArrivalCity = ' " + arriwalCity + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, Program.connect);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    int i = 0;
                    foreach (DataRow row1 in dataTable.Rows)
                    {
                        // Access each column using the column name or index
                        var tourId1 = row1["Tour_ID"];
                        var departureCity1 = row1["DepartureCity"];
                        var arrivalCity1 = row1["ArrivalCity"];
                        var departureDate1 = row1["DepartureDate"];
                        var arrivalDate1 = row1["ArrivalDate"];

                        Button button = new Button();
                        button.Text = $"DepartureCity: {departureCity1},\nDepartureDate: {departureDate1},\n\nArrivalCity: {arrivalCity1},\nArrivalDate: {arrivalDate1}, \nTour ID: {tourId1}";
                       
                            //"Departure: 2024-09-07 05:20\nArrival: 2024-09-07 05:20\n\n\n    RESERVE"
                        int column = 5 % NUMBER_OF_BUTTON_COLUMNS;
                        int row = i;
                        button.Left = column * (BUTTON_MARGIN + 40);
                        button.Top = row * (BUTTON_MARGIN + 40);
                        button.Width = BUTTON_WIDTH;
                        button.Height = BUTTON_HEIGHT;
                        this.Controls.Add(button);
                        button.Click += new EventHandler(Reserve_Button);
                        i++;

                    }
                }       
            }
            catch (Exception hata)
            {
                MessageBox.Show("Error: " + hata.Message);
            }

        }

        public void AddToDb(string tour_id)
        {
            int SSN = 0;
            try
            {
                String querrySSN = "Select SSN from Tourists where email = '" + Login.email + "'";
                SqlDataAdapter sdaSSN = new SqlDataAdapter(querrySSN, Program.connect);
                DataTable dataTableSSN = new DataTable();
                sdaSSN.Fill(dataTableSSN);

                foreach (DataRow row1 in dataTableSSN.Rows)
                {
                    SSN = (int)row1["SSN"];
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Error: " + hata.Message);
            }


            try
            {
                if (Program.connect.State == ConnectionState.Closed)
                {
                    Program.connect.Open();
                }
                string kayit = "insert into reservations(ReserveDate,Reserve_ID,Tour_ID,SSN) values(@date,@r_id,@t_id,@ssn)";

                SqlCommand komut = new SqlCommand(kayit, Program.connect);

                komut.Parameters.AddWithValue("@ssn", SSN);
                komut.Parameters.AddWithValue("@date", DateTime.UtcNow);
                komut.Parameters.AddWithValue("@r_id", new Random().Next(1114854, 1119458));
                komut.Parameters.AddWithValue("@t_id", tour_id);

                komut.ExecuteNonQuery();

                MessageBox.Show("You have successfuly reserved this Tour");


            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi" + hata.Message);
            }



        }
        public void Button_Click(object sender, EventArgs e)
        {
            AddButtons();
        }

        public void Reserve_Button(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            AddToDb(btn.Text.Split(new[] { "Tour ID: " }, StringSplitOptions.None)[1]);
        }
    }
}
