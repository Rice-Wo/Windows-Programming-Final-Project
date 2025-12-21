using System;
using System.Windows.Forms;
using WindowsProgrammingFinalProject.Blackjack;
using WindowsProgrammingFinalProject.GuessNumber;
using WindowsProgrammingFinalProject.RockPaperScissor;

namespace WindowsProgrammingFinalProject
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void RPSGameButton_ClickEvent(object sender, EventArgs e)
        {
            RPSForm RPSForm = new RPSForm();
            this.Hide();
            RPSForm.ShowDialog();
            this.Show();
        }

        private void GuessNumberGameButton_Click(object sender, EventArgs e)
        {
            GuessNumberForm guessNumber = new GuessNumberForm();
            this.Hide();
            guessNumber.ShowDialog();
            this.Show();
        }

        private void BlkjkGameButton_Click(object sender, EventArgs e)
        {
            BlackjackForm blackjackForm = new BlackjackForm();
            this.Hide();
            blackjackForm.ShowDialog();
            this.Show();
        }
    }
}
