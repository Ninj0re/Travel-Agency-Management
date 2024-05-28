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
    public partial class MyReservations : Form
    {
        const int NUMBER_OF_BUTTON_COLUMNS = 6;
        const int BUTTON_HEIGHT = 150;
        const int BUTTON_WIDTH = 210;
        const int BUTTON_MARGIN = 70;
        Login login;
        public MyReservations(Login login)
        {
            InitializeComponent();
            AddButtons();
            this.login = login;
        }

        private void My_reservations_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Reserve(login).Show();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        public void AddButtons()
        {


            

            int SSN = 0;
            try
            {
                String querrySSN = "Select SSN from Tourists where email = '"+Login.email+ "'";
                SqlDataAdapter sdaSSN = new SqlDataAdapter(querrySSN, Program.connect);
                DataTable dataTableSSN = new DataTable();
                sdaSSN.Fill(dataTableSSN);

                foreach (DataRow row1 in dataTableSSN.Rows)
                {
                    SSN = (int)row1["SSN"];
                }


                String querryTour_Id = "Select * from Tourists t INNER JOIN Reservations r ON t.SSN = r.SSN where t.SSN = '" +SSN+ "'";
                SqlDataAdapter sdaTour_Id = new SqlDataAdapter(querryTour_Id, Program.connect);
                DataTable dataTableTour_Id = new DataTable();
                sdaTour_Id.Fill(dataTableTour_Id);
                var Tour_ID = 0;
                if (dataTableTour_Id.Rows.Count > 0)
                {
                   
                    foreach (DataRow row1 in dataTableTour_Id.Rows)
                    {
                         Tour_ID = (int)row1["Tour_ID"];
                    }

                }


   String querryFinal = "Select * from Reservations r INNER JOIN Tours t ON t.Tour_ID = r.Tour_ID where r.SSN = '" + SSN + "'";
                  SqlDataAdapter sdaFinal = new SqlDataAdapter(querryFinal, Program.connect);
                  DataTable dataTableFinal = new DataTable();
                  sdaFinal.Fill(dataTableFinal);
                  //Select * from Reservations r INNER JOIN Tours t ON t.Tour_ID = r.Tour_ID where t.Tour_ID = 82216 and r.SSN = 100038327;
                  
                  if (dataTableFinal.Rows.Count > 0)
                  {
                    int i = 0;
                    foreach (DataRow row1 in dataTableFinal.Rows)
                      {
                        
                        var departureCity1 = row1["DepartureCity"];
                        var arrivalCity1 = row1["ArrivalCity"];
                        var departureDate1 = row1["DepartureDate"];
                        var arrivalDate1 = row1["ArrivalDate"];


                        Button button = new Button();
                        button.Text = $"DepartureCity: {departureCity1},\nDepartureDate: {departureDate1},\n\nArrivalCity: {arrivalCity1},\nArrivalDate: {arrivalDate1}, \n\nTour ID: {Tour_ID}, \n\nREVIEW:";

                        int column = 5 % NUMBER_OF_BUTTON_COLUMNS;
                        int row = i;
                        button.Left = column * (BUTTON_MARGIN);
                        button.Top = row * (BUTTON_MARGIN + 40);
                        button.Width = BUTTON_WIDTH;
                        button.Height = BUTTON_HEIGHT;
                        this.Controls.Add(button);
                        //  button.Click += new EventHandler(Button_Click);

                        i++;
                        i++;
                    }

                  }



            }
            catch (Exception hata)
            {
                MessageBox.Show("Error: " + hata.Message);
            }


        }

        private void Button_ClickedEvent(object sender, EventArgs e)
        {
            //Use the sender object to work out which button was clicked.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
