using System.Windows.Forms;

namespace WindowsProgrammingFinalProject.GuessNumber
{
    public partial class GuessNumberForm : Form
    {
        private Button SubmitButton;
        private TextBox AnserTextBox;
        private RichTextBox ResultRichTextBox;

        public GuessNumberForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SubmitButton = new System.Windows.Forms.Button();
            this.AnserTextBox = new System.Windows.Forms.TextBox();
            this.ResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.SubmitButton.Location = new System.Drawing.Point(150, 421);
            this.SubmitButton.Name = "button1";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "button1";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.AnserTextBox.Location = new System.Drawing.Point(140, 377);
            this.AnserTextBox.Name = "textBox1";
            this.AnserTextBox.Size = new System.Drawing.Size(100, 22);
            this.AnserTextBox.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.ResultRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.ResultRichTextBox.Name = "richTextBox1";
            this.ResultRichTextBox.ReadOnly = true;
            this.ResultRichTextBox.Size = new System.Drawing.Size(357, 349);
            this.ResultRichTextBox.TabIndex = 2;
            this.ResultRichTextBox.Text = "";
            // 
            // GuessNumberForm
            // 
            this.ClientSize = new System.Drawing.Size(398, 474);
            this.Controls.Add(this.ResultRichTextBox);
            this.Controls.Add(this.AnserTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Name = "GuessNumberForm";
            this.Text = "猜數字";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
