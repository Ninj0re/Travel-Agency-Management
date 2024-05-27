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
    public partial class Reserve : Form
    {
        const int NUMBER_OF_BUTTON_COLUMNS = 6;
        const int BUTTON_HEIGHT = 80;
        const int BUTTON_WIDTH = 200;
        const int BUTTON_MARGIN = 50;
        public Reserve()
        {
            InitializeComponent();
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
            new MyReservations().Show();
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
                button.Text = "Departure: 2024-09-07 05:20\nArrival: 2024-09-07 05:20\n\n\n    RESERVE";
                int column = 5 % NUMBER_OF_BUTTON_COLUMNS;
                int row = i;
                button.Left = column * (BUTTON_MARGIN + 40);
                button.Top = row * (BUTTON_MARGIN + 40);
                button.Width = BUTTON_WIDTH;
                button.Height = BUTTON_HEIGHT;
                this.Controls.Add(button);
                button.Click += new EventHandler(Button_Click);
            }
        }
        public void Button_Click(object sender, EventArgs e)
        {
            AddButtons();
        }
    }
}
