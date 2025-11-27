using System;
using System.Windows.Forms;
using WindowsProgrammingFinalProject.GuessNumber;

namespace WindowsProgrammingFinalProject
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
