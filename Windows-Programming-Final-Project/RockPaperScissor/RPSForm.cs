using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProgrammingFinalProject.RockPaperScissor
{
    public partial class RPSForm : Form
    {
        private static readonly Image rockImage = Properties.Resources.Rock;
        private static readonly Image scissorImage = Properties.Resources.Scissor;
        private static readonly Image paperImage = Properties.Resources.Paper;
        private static readonly Image[] images = { rockImage, scissorImage, paperImage };
        public RPSForm()
        {
            InitializeComponent();
        }
        readonly RPS rps = new RPS(); // create an instance of RPS class

        private void RockButton_Click(object sender, EventArgs e)
        {
            HandleGamePlay("石頭");
        }

        private void ScissorButton_Click(object sender, EventArgs e)
        {
            HandleGamePlay("剪刀");
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            HandleGamePlay("布");
        }

        private async void RefreshForm(int comInput, Image playerChoiceImage, string result)
        {
            // 1. 按下瞬間：清空圖片並禁用按鈕
            PlayerImage.Image = null;
            ComImage.Image = null;
            ResultLabel.Text = ""; // 增加期待感
    
            RockButton.Enabled = false;
            ScissorButton.Enabled = false;
            PaperButton.Enabled = false;

            // 2. 等待時間 (增加手感，建議 300~500ms 即可，1秒可能有點久)
            await Task.Delay(500); 

            // 3. 顯示結果
            PlayerImage.Image = playerChoiceImage;
            ComImage.Image = images[comInput];
            StatsLabel.Text = rps.Statistics();
            ResultLabel.Text = result;

            // 4. 恢復按鈕
            RockButton.Enabled = true;
            ScissorButton.Enabled = true;
            PaperButton.Enabled = true;
        }

        private void HandleGamePlay(string playerChoice)
        {
            int comInput = rps.GetRandomInput();
            string result = rps.Game(playerChoice, comInput);
            Image playerChoiceImage = null;
            switch (playerChoice)
            {
                case "石頭":
                    playerChoiceImage = rockImage;
                    break;
                case "剪刀":
                    playerChoiceImage = scissorImage;
                    break;
                case "布":
                    playerChoiceImage = paperImage;
                    break;
            }
            RefreshForm(comInput, playerChoiceImage, result);
        }
    }
}
