namespace WindowsProgrammingFinalProject.RockPaperScissor
{
    partial class RPSForm
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
            this.RockButton = new System.Windows.Forms.Button();
            this.ScissorButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.PlayerImage = new System.Windows.Forms.PictureBox();
            this.ComImage = new System.Windows.Forms.PictureBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.ComNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComImage)).BeginInit();
            this.SuspendLayout();
            // 
            // RockButton
            // 
            this.RockButton.Location = new System.Drawing.Point(41, 217);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(75, 23);
            this.RockButton.TabIndex = 0;
            this.RockButton.Text = "石頭";
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // ScissorButton
            // 
            this.ScissorButton.Location = new System.Drawing.Point(41, 260);
            this.ScissorButton.Name = "ScissorButton";
            this.ScissorButton.Size = new System.Drawing.Size(75, 23);
            this.ScissorButton.TabIndex = 1;
            this.ScissorButton.Text = "剪刀";
            this.ScissorButton.UseVisualStyleBackColor = true;
            this.ScissorButton.Click += new System.EventHandler(this.ScissorButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.Location = new System.Drawing.Point(41, 300);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(75, 23);
            this.PaperButton.TabIndex = 2;
            this.PaperButton.Text = "布";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // PlayerImage
            // 
            this.PlayerImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayerImage.InitialImage = global::WindowsProgrammingFinalProject.Properties.Resources.Rock;
            this.PlayerImage.Location = new System.Drawing.Point(12, 43);
            this.PlayerImage.Name = "PlayerImage";
            this.PlayerImage.Size = new System.Drawing.Size(218, 171);
            this.PlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerImage.TabIndex = 3;
            this.PlayerImage.TabStop = false;
            // 
            // ComImage
            // 
            this.ComImage.InitialImage = null;
            this.ComImage.Location = new System.Drawing.Point(266, 43);
            this.ComImage.Name = "ComImage";
            this.ComImage.Size = new System.Drawing.Size(209, 171);
            this.ComImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComImage.TabIndex = 4;
            this.ComImage.TabStop = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(361, 260);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(59, 12);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "Placeholder";
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(83, 9);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(33, 12);
            this.PlayerNameLabel.TabIndex = 6;
            this.PlayerNameLabel.Text = "label1";
            // 
            // ComNameLabel
            // 
            this.ComNameLabel.AutoSize = true;
            this.ComNameLabel.Location = new System.Drawing.Point(361, 9);
            this.ComNameLabel.Name = "ComNameLabel";
            this.ComNameLabel.Size = new System.Drawing.Size(33, 12);
            this.ComNameLabel.TabIndex = 7;
            this.ComNameLabel.Text = "label1";
            // 
            // RPSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 358);
            this.Controls.Add(this.ComNameLabel);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ComImage);
            this.Controls.Add(this.PlayerImage);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.ScissorButton);
            this.Controls.Add(this.RockButton);
            this.Name = "RPSForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button ScissorButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.PictureBox PlayerImage;
        private System.Windows.Forms.PictureBox ComImage;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label ComNameLabel;
    }
}