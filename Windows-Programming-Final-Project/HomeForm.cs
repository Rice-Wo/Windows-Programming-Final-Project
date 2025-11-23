using System;
using System.Windows.Forms;
using GuessNumber;

namespace Windows_Programming_Final_Project
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuessNumberForm guessNumberForm = new GuessNumberForm();
            this.Hide();
            guessNumberForm.ShowDialog();
            this.Show();
        }
    }
}
