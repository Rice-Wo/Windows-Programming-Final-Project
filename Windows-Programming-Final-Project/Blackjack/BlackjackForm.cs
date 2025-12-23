using System;
using System.Windows.Forms;

namespace WindowsProgrammingFinalProject.Blackjack
{
    public partial class BlackjackForm : Form
    {
        public BlackjackForm()
        {
            InitializeComponent();
        }

        Blackjack game = new Blackjack();

        private void GameStart(object sender, EventArgs e)
        {
            // 初始化遊戲
            DealerDeckDisplay.Text = "";
            game.GameStart();
            UpdateUI();
            if (game.PlayerPoint == 21)
            {
                GameOver();
                return;
            }
            GameResultLbl.Text = "";
            DealerDeckDisplay.Text = game.ComputerHand[0] + ", ??";
            DealerPointsLbl.Text = "莊家點數: ?";
            HitButton.Enabled = true;
            StandButton.Enabled = true;
            NextRoundButton.Enabled = false;
        }

        private void UpdateUI()
        {
            // 更新玩家手牌顯示
            PlayerDeckDisplay.Text = string.Join(", ", game.PlayerHand);
            PlayerPointLbl.Text = $"玩家點數: {game.PlayerPoint}";
        }

        private void BlackjackForm_Load(object sender, EventArgs e)
        {
            GameStart(sender, e);
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            game.GameAddCard();
            UpdateUI();
            if (game.PlayerPoint >= 21)
            {
                GameOver();
            }
        }

        private void StandButton_Click(object sender, EventArgs e)
        {

            game.GameEnd();
            DealerDeckDisplay.Text = string.Join(", ", game.ComputerHand);
            DealerPointsLbl.Text = $"莊家點數: {game.CalculatePoints(game.ComputerHand)}";
            GameOver();
        }

        private void GameOver()
        {
            HitButton.Enabled = false;
            StandButton.Enabled = false;
            GameResultLbl.Text = game.GetResult();
            NextRoundButton.Enabled = true;
            StatsLbl.Text = game.Statistics();
        }

        private void StatsLbl_Click(object sender, EventArgs e)
        {
            NextRoundButton.Enabled = true; // for testing
        }

        private void NextRoundButton_Click(object sender, EventArgs e)
        {
            GameStart(sender, e);
        }
    }
}
