namespace WindowsProgrammingFinalProject.Blackjack
{
    partial class BlackjackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StandButton = new System.Windows.Forms.Button();
            this.HitButton = new System.Windows.Forms.Button();
            this.PlayerDeckDisplay = new System.Windows.Forms.RichTextBox();
            this.DealerDeckDisplay = new System.Windows.Forms.RichTextBox();
            this.DealerPointsLbl = new System.Windows.Forms.Label();
            this.PlayerPointLbl = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.DealerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StandButton
            // 
            this.StandButton.Location = new System.Drawing.Point(458, 276);
            this.StandButton.Margin = new System.Windows.Forms.Padding(4);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(88, 31);
            this.StandButton.TabIndex = 0;
            this.StandButton.Text = "停牌";
            this.StandButton.UseVisualStyleBackColor = true;
            // 
            // HitButton
            // 
            this.HitButton.Location = new System.Drawing.Point(458, 216);
            this.HitButton.Margin = new System.Windows.Forms.Padding(4);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(88, 31);
            this.HitButton.TabIndex = 1;
            this.HitButton.Text = "要牌";
            this.HitButton.UseVisualStyleBackColor = true;
            // 
            // PlayerDeckDisplay
            // 
            this.PlayerDeckDisplay.Location = new System.Drawing.Point(182, 207);
            this.PlayerDeckDisplay.Name = "PlayerDeckDisplay";
            this.PlayerDeckDisplay.ReadOnly = true;
            this.PlayerDeckDisplay.Size = new System.Drawing.Size(100, 96);
            this.PlayerDeckDisplay.TabIndex = 2;
            this.PlayerDeckDisplay.Text = "";
            // 
            // DealerDeckDisplay
            // 
            this.DealerDeckDisplay.Location = new System.Drawing.Point(182, 49);
            this.DealerDeckDisplay.Name = "DealerDeckDisplay";
            this.DealerDeckDisplay.ReadOnly = true;
            this.DealerDeckDisplay.Size = new System.Drawing.Size(100, 96);
            this.DealerDeckDisplay.TabIndex = 3;
            this.DealerDeckDisplay.Text = "";
            // 
            // DealerPointsLbl
            // 
            this.DealerPointsLbl.AutoSize = true;
            this.DealerPointsLbl.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DealerPointsLbl.Location = new System.Drawing.Point(297, 125);
            this.DealerPointsLbl.Name = "DealerPointsLbl";
            this.DealerPointsLbl.Size = new System.Drawing.Size(105, 20);
            this.DealerPointsLbl.TabIndex = 4;
            this.DealerPointsLbl.Text = "莊家點數：？";
            // 
            // PlayerPointLbl
            // 
            this.PlayerPointLbl.AutoSize = true;
            this.PlayerPointLbl.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PlayerPointLbl.Location = new System.Drawing.Point(297, 283);
            this.PlayerPointLbl.Name = "PlayerPointLbl";
            this.PlayerPointLbl.Size = new System.Drawing.Size(89, 20);
            this.PlayerPointLbl.TabIndex = 5;
            this.PlayerPointLbl.Text = "玩家點數：";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PlayerLabel.Location = new System.Drawing.Point(215, 175);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(41, 20);
            this.PlayerLabel.TabIndex = 6;
            this.PlayerLabel.Text = "玩家";
            // 
            // DealerLabel
            // 
            this.DealerLabel.AutoSize = true;
            this.DealerLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DealerLabel.Location = new System.Drawing.Point(215, 19);
            this.DealerLabel.Name = "DealerLabel";
            this.DealerLabel.Size = new System.Drawing.Size(41, 20);
            this.DealerLabel.TabIndex = 7;
            this.DealerLabel.Text = "莊家";
            // 
            // BlackjackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 493);
            this.Controls.Add(this.DealerLabel);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.PlayerPointLbl);
            this.Controls.Add(this.DealerPointsLbl);
            this.Controls.Add(this.DealerDeckDisplay);
            this.Controls.Add(this.PlayerDeckDisplay);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.StandButton);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BlackjackForm";
            this.Text = "二十一點";
            this.Load += new System.EventHandler(this.BlackjackForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StandButton;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.RichTextBox PlayerDeckDisplay;
        private System.Windows.Forms.RichTextBox DealerDeckDisplay;
        private System.Windows.Forms.Label DealerPointsLbl;
        private System.Windows.Forms.Label PlayerPointLbl;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label DealerLabel;
    }
}