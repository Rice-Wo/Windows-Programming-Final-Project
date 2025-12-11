using System;
using System.Drawing;
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
            int comInput = rps.GetRandomInput();
            ComImage.Image = images[comInput];
            string result = rps.Game("石頭", comInput);
            PlayerImage.Image = rockImage;
            ResultLabel.Text = result;
        }

        private void ScissorButton_Click(object sender, EventArgs e)
        {
            int comInput = rps.GetRandomInput();
            ComImage.Image = images[comInput];
            string result = rps.Game("剪刀", comInput);
            PlayerImage.Image = scissorImage;
            ResultLabel.Text = result;
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            int comInput = rps.GetRandomInput();
            ComImage.Image = images[comInput];
            string result = rps.Game("布", comInput);
            PlayerImage.Image = paperImage;
            ResultLabel.Text = result;
        }
    }
}
