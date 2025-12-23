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

        private void AboutTSMI_Click(object sender, EventArgs e)
        {
            string version = Application.ProductVersion;
            string info = $"Windows Programming Final Project\n" +
                          $"版本: {version}\n" +
                          $"作者: Rice_Wo\n" +
                          $"年分: 2025";
            MessageBox.Show(info);
        }
    }
}
