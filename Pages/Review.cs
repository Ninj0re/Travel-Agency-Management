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
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfuly send your review.");
            this.Hide();
        }
    }
}
