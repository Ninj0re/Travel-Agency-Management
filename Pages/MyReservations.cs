using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        const int BUTTON_HEIGHT = 80;
        const int BUTTON_WIDTH = 200;
        const int BUTTON_MARGIN = 50;
        public MyReservations()
        {
            InitializeComponent();
            AddButtons();
        }

        private void My_reservations_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Reserve().Show();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        public void AddButtons()
        {

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Text = "Departure: City\nArrival: City\n\n\n    REVİEW";
                int column = 3;
                int row = i+1;
                button.Left = column * (BUTTON_MARGIN + 40);
                button.Top = row * (BUTTON_MARGIN + 40);
                button.Width = BUTTON_WIDTH;
                button.Height = BUTTON_HEIGHT;
                this.Controls.Add(button);
                button.Click += new EventHandler(Button_ClickedEvent);
            }
        }

        private void Button_ClickedEvent(object sender, EventArgs e)
        {
            //Use the sender object to work out which button was clicked.
        }
    }
}
