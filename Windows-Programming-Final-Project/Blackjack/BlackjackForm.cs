using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            game = new Blackjack();
            game.GameStart();
            UpdateUI();
            DealerDeckDisplay.Text = game.ComputerHand[0] + ", ??";
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
    }
}
