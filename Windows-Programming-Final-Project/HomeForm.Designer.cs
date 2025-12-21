namespace WindowsProgrammingFinalProject
{
    partial class HomeForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.RPSGameButton = new System.Windows.Forms.Button();
            this.GuessNumberGameButton = new System.Windows.Forms.Button();
            this.BlkjkGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RPSGameButton
            // 
            this.RPSGameButton.Location = new System.Drawing.Point(82, 46);
            this.RPSGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.RPSGameButton.Name = "RPSGameButton";
            this.RPSGameButton.Size = new System.Drawing.Size(88, 31);
            this.RPSGameButton.TabIndex = 0;
            this.RPSGameButton.Text = "剪刀石頭布";
            this.RPSGameButton.UseVisualStyleBackColor = true;
            this.RPSGameButton.Click += new System.EventHandler(this.RPSGameButton_ClickEvent);
            // 
            // GuessNumberGameButton
            // 
            this.GuessNumberGameButton.Location = new System.Drawing.Point(82, 120);
            this.GuessNumberGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuessNumberGameButton.Name = "GuessNumberGameButton";
            this.GuessNumberGameButton.Size = new System.Drawing.Size(88, 31);
            this.GuessNumberGameButton.TabIndex = 1;
            this.GuessNumberGameButton.Text = "猜數字";
            this.GuessNumberGameButton.UseVisualStyleBackColor = true;
            this.GuessNumberGameButton.Click += new System.EventHandler(this.GuessNumberGameButton_Click);
            // 
            // BlkjkGameButton
            // 
            this.BlkjkGameButton.Location = new System.Drawing.Point(82, 183);
            this.BlkjkGameButton.Name = "BlkjkGameButton";
            this.BlkjkGameButton.Size = new System.Drawing.Size(88, 29);
            this.BlkjkGameButton.TabIndex = 2;
            this.BlkjkGameButton.Text = "二十一點";
            this.BlkjkGameButton.UseVisualStyleBackColor = true;
            this.BlkjkGameButton.Click += new System.EventHandler(this.BlkjkGameButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 282);
            this.Controls.Add(this.BlkjkGameButton);
            this.Controls.Add(this.GuessNumberGameButton);
            this.Controls.Add(this.RPSGameButton);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.Text = "Final-Project";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RPSGameButton;
        private System.Windows.Forms.Button GuessNumberGameButton;
        private System.Windows.Forms.Button BlkjkGameButton;
    }
}

