using System.Windows.Forms;

namespace WindowsProgrammingFinalProject.GuessNumber
{
    public partial class GuessNumberForm : Form
    {

        private Button SubmitButton;
        private TextBox AnserTextBox;
        private ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private Label RuleLabel;
        private Button NextRoundButton;
        private RichTextBox ResultRichTextBox;

        public GuessNumberForm()
        {
            InitializeComponent();
            GameStart();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.AnserTextBox = new System.Windows.Forms.TextBox();
            this.ResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RuleLabel = new System.Windows.Forms.Label();
            this.NextRoundButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(50, 412);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "輸入答案";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // AnserTextBox
            // 
            this.AnserTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.AnserTextBox.Location = new System.Drawing.Point(38, 367);
            this.AnserTextBox.MaxLength = 4;
            this.AnserTextBox.Name = "AnserTextBox";
            this.AnserTextBox.Size = new System.Drawing.Size(100, 23);
            this.AnserTextBox.TabIndex = 1;
            this.AnserTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnserTextBox_KeyDown_Enter);
            // 
            // ResultRichTextBox
            // 
            this.ResultRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.ResultRichTextBox.Name = "ResultRichTextBox";
            this.ResultRichTextBox.ReadOnly = true;
            this.ResultRichTextBox.Size = new System.Drawing.Size(156, 349);
            this.ResultRichTextBox.TabIndex = 2;
            this.ResultRichTextBox.Text = "";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // RuleLabel
            // 
            this.RuleLabel.AutoSize = true;
            this.RuleLabel.Location = new System.Drawing.Point(214, 27);
            this.RuleLabel.Name = "RuleLabel";
            this.RuleLabel.Size = new System.Drawing.Size(171, 208);
            this.RuleLabel.TabIndex = 3;
            this.RuleLabel.Text = "【 遊戲規則 】\n\n系統產生一組 4 位數字。\n\n請在下方輸入數字後按 Enter。\n\n判定標準：\n\nA：數字正確，且位置正確。\n\nB：數字正確，但位置不對。\n\n" +
    "猜中 4A 即獲勝。";
            // 
            // NextRoundButton
            // 
            this.NextRoundButton.Enabled = false;
            this.NextRoundButton.Location = new System.Drawing.Point(257, 303);
            this.NextRoundButton.Name = "NextRoundButton";
            this.NextRoundButton.Size = new System.Drawing.Size(75, 23);
            this.NextRoundButton.TabIndex = 4;
            this.NextRoundButton.Text = "下一局";
            this.NextRoundButton.UseVisualStyleBackColor = true;
            this.NextRoundButton.Click += new System.EventHandler(this.NextRoundButton_Click);
            // 
            // GuessNumberForm
            // 
            this.ClientSize = new System.Drawing.Size(398, 474);
            this.Controls.Add(this.NextRoundButton);
            this.Controls.Add(this.RuleLabel);
            this.Controls.Add(this.ResultRichTextBox);
            this.Controls.Add(this.AnserTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "GuessNumberForm";
            this.Text = "猜數字";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // 以上為設計工具自動產生的程式碼
        bool isGameOver = false;
        GuessNumber game = new GuessNumber();
        string answer;

        private void SubmitAnser()
        {
            string userGuess = AnserTextBox.Text;
            try
            {
                int.Parse(AnserTextBox.Text);
            }
            catch (System.Exception)
            {

                toolTip1.Show("請輸入四位數字", AnserTextBox, 500);
                AnserTextBox.Clear();
                return;
            }
            string result = game.MakeGuess(userGuess, answer);
            ResultRichTextBox.AppendText(result + "\n");
            if (result.Contains("恭喜"))
            {
                isGameOver = true;
                SubmitButton.Enabled = false;
                NextRoundButton.Enabled = true;
            }
            ResultRichTextBox.ScrollToCaret();
            AnserTextBox.Clear();
        }

        private void AnserTextBox_KeyDown_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (isGameOver)
                {
                    GameStart();
                }
                else
                {
                    string userGuess = AnserTextBox.Text;
                    // 在這裡處理按下 Enter 鍵的邏輯
                    if (userGuess == "ans?")
                    {
                        AnserTextBox.Text = answer;
                    }
                    else if (userGuess.Length == 4)
                    {
                        SubmitAnser();
                        e.SuppressKeyPress = true; // 防止系統發出「嗶」聲
                    }
                    else
                    {
                        toolTip1.Show("請輸入四位數字", AnserTextBox, 500);
                        AnserTextBox.Clear();
                        AnserTextBox.Focus();
                    }
                }
            }
        }

        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            string userGuess = AnserTextBox.Text;
            if (userGuess == "ans?")
            {
                AnserTextBox.Text = answer;
            }
            else if (userGuess.Length == 4)
            {
                SubmitAnser();
            }
            else
            {
                toolTip1.Show("請輸入四位數字", AnserTextBox, 500);
                AnserTextBox.Clear();
                AnserTextBox.Focus();
            }
        }

        private void NextRoundButton_Click(object sender, System.EventArgs e)
        {
            GameStart();
        }

        private void GameStart()
        {
            answer = game.GetAnswer();
            ResultRichTextBox.Clear();
            isGameOver = false;
            SubmitButton.Enabled = true;
            NextRoundButton.Enabled = false;
        }
    }


}
