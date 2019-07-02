namespace internet_demo
{
    partial class Form1
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
            this.searchButton = new System.Windows.Forms.Button();
            this.heroSearchBox = new System.Windows.Forms.TextBox();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.durabilityLabel = new System.Windows.Forms.Label();
            this.combatLabel = new System.Windows.Forms.Label();
            this.intelligenceBar = new System.Windows.Forms.ProgressBar();
            this.powerBar = new System.Windows.Forms.ProgressBar();
            this.speedBar = new System.Windows.Forms.ProgressBar();
            this.durabilityBar = new System.Windows.Forms.ProgressBar();
            this.strengthBar = new System.Windows.Forms.ProgressBar();
            this.combatBar = new System.Windows.Forms.ProgressBar();
            this.intelligencePercentLabel = new System.Windows.Forms.Label();
            this.combatPercentLabel = new System.Windows.Forms.Label();
            this.strengthPercentLabel = new System.Windows.Forms.Label();
            this.speedPercentLabel = new System.Windows.Forms.Label();
            this.durabilityPercentLabel = new System.Windows.Forms.Label();
            this.powerPercentLabel = new System.Windows.Forms.Label();
            this.heroPortraitBoxLeft = new System.Windows.Forms.PictureBox();
            this.heroPortraitBoxRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.heroPortraitBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroPortraitBoxRight)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(693, 13);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(168, 40);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "&Character Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // heroSearchBox
            // 
            this.heroSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heroSearchBox.Location = new System.Drawing.Point(13, 21);
            this.heroSearchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heroSearchBox.Name = "heroSearchBox";
            this.heroSearchBox.Size = new System.Drawing.Size(672, 25);
            this.heroSearchBox.TabIndex = 1;
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.Location = new System.Drawing.Point(12, 57);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(98, 19);
            this.intelligenceLabel.TabIndex = 2;
            this.intelligenceLabel.Text = "Intelligence";
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(12, 93);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(75, 19);
            this.strengthLabel.TabIndex = 3;
            this.strengthLabel.Text = "Strength";
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(12, 201);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(54, 19);
            this.powerLabel.TabIndex = 4;
            this.powerLabel.Text = "Power";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(12, 129);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(54, 19);
            this.speedLabel.TabIndex = 5;
            this.speedLabel.Text = "Speed";
            // 
            // durabilityLabel
            // 
            this.durabilityLabel.AutoSize = true;
            this.durabilityLabel.Location = new System.Drawing.Point(12, 165);
            this.durabilityLabel.Name = "durabilityLabel";
            this.durabilityLabel.Size = new System.Drawing.Size(84, 19);
            this.durabilityLabel.TabIndex = 6;
            this.durabilityLabel.Text = "Durability";
            // 
            // combatLabel
            // 
            this.combatLabel.AutoSize = true;
            this.combatLabel.Location = new System.Drawing.Point(12, 237);
            this.combatLabel.Name = "combatLabel";
            this.combatLabel.Size = new System.Drawing.Size(65, 19);
            this.combatLabel.TabIndex = 7;
            this.combatLabel.Text = "Combat";
            // 
            // intelligenceBar
            // 
            this.intelligenceBar.BackColor = System.Drawing.SystemColors.Control;
            this.intelligenceBar.Location = new System.Drawing.Point(116, 57);
            this.intelligenceBar.MarqueeAnimationSpeed = 1000;
            this.intelligenceBar.Name = "intelligenceBar";
            this.intelligenceBar.Size = new System.Drawing.Size(569, 23);
            this.intelligenceBar.TabIndex = 8;
            // 
            // powerBar
            // 
            this.powerBar.Location = new System.Drawing.Point(116, 201);
            this.powerBar.Name = "powerBar";
            this.powerBar.Size = new System.Drawing.Size(569, 23);
            this.powerBar.TabIndex = 9;
            // 
            // speedBar
            // 
            this.speedBar.Location = new System.Drawing.Point(116, 129);
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(569, 23);
            this.speedBar.TabIndex = 10;
            // 
            // durabilityBar
            // 
            this.durabilityBar.Location = new System.Drawing.Point(116, 165);
            this.durabilityBar.Name = "durabilityBar";
            this.durabilityBar.Size = new System.Drawing.Size(569, 23);
            this.durabilityBar.TabIndex = 11;
            // 
            // strengthBar
            // 
            this.strengthBar.BackColor = System.Drawing.SystemColors.Control;
            this.strengthBar.Location = new System.Drawing.Point(116, 93);
            this.strengthBar.MarqueeAnimationSpeed = 1000;
            this.strengthBar.Name = "strengthBar";
            this.strengthBar.Size = new System.Drawing.Size(569, 23);
            this.strengthBar.TabIndex = 12;
            // 
            // combatBar
            // 
            this.combatBar.Location = new System.Drawing.Point(116, 237);
            this.combatBar.Name = "combatBar";
            this.combatBar.Size = new System.Drawing.Size(569, 23);
            this.combatBar.TabIndex = 13;
            // 
            // intelligencePercentLabel
            // 
            this.intelligencePercentLabel.AutoSize = true;
            this.intelligencePercentLabel.Location = new System.Drawing.Point(717, 58);
            this.intelligencePercentLabel.Name = "intelligencePercentLabel";
            this.intelligencePercentLabel.Size = new System.Drawing.Size(45, 19);
            this.intelligencePercentLabel.TabIndex = 14;
            this.intelligencePercentLabel.Text = "/100";
            this.intelligencePercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combatPercentLabel
            // 
            this.combatPercentLabel.AutoSize = true;
            this.combatPercentLabel.Location = new System.Drawing.Point(717, 238);
            this.combatPercentLabel.Name = "combatPercentLabel";
            this.combatPercentLabel.Size = new System.Drawing.Size(45, 19);
            this.combatPercentLabel.TabIndex = 15;
            this.combatPercentLabel.Text = "/100";
            this.combatPercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // strengthPercentLabel
            // 
            this.strengthPercentLabel.AutoSize = true;
            this.strengthPercentLabel.Location = new System.Drawing.Point(717, 94);
            this.strengthPercentLabel.Name = "strengthPercentLabel";
            this.strengthPercentLabel.Size = new System.Drawing.Size(45, 19);
            this.strengthPercentLabel.TabIndex = 16;
            this.strengthPercentLabel.Text = "/100";
            this.strengthPercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // speedPercentLabel
            // 
            this.speedPercentLabel.AutoSize = true;
            this.speedPercentLabel.Location = new System.Drawing.Point(717, 130);
            this.speedPercentLabel.Name = "speedPercentLabel";
            this.speedPercentLabel.Size = new System.Drawing.Size(45, 19);
            this.speedPercentLabel.TabIndex = 17;
            this.speedPercentLabel.Text = "/100";
            this.speedPercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // durabilityPercentLabel
            // 
            this.durabilityPercentLabel.AutoSize = true;
            this.durabilityPercentLabel.Location = new System.Drawing.Point(717, 166);
            this.durabilityPercentLabel.Name = "durabilityPercentLabel";
            this.durabilityPercentLabel.Size = new System.Drawing.Size(45, 19);
            this.durabilityPercentLabel.TabIndex = 18;
            this.durabilityPercentLabel.Text = "/100";
            this.durabilityPercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // powerPercentLabel
            // 
            this.powerPercentLabel.AutoSize = true;
            this.powerPercentLabel.Location = new System.Drawing.Point(717, 202);
            this.powerPercentLabel.Name = "powerPercentLabel";
            this.powerPercentLabel.Size = new System.Drawing.Size(45, 19);
            this.powerPercentLabel.TabIndex = 19;
            this.powerPercentLabel.Text = "/100";
            this.powerPercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // heroPortraitBoxLeft
            // 
            this.heroPortraitBoxLeft.Location = new System.Drawing.Point(16, 275);
            this.heroPortraitBoxLeft.Name = "heroPortraitBoxLeft";
            this.heroPortraitBoxLeft.Size = new System.Drawing.Size(350, 371);
            this.heroPortraitBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heroPortraitBoxLeft.TabIndex = 20;
            this.heroPortraitBoxLeft.TabStop = false;
            // 
            // heroPortraitBoxRight
            // 
            this.heroPortraitBoxRight.Location = new System.Drawing.Point(511, 275);
            this.heroPortraitBoxRight.Name = "heroPortraitBoxRight";
            this.heroPortraitBoxRight.Size = new System.Drawing.Size(350, 371);
            this.heroPortraitBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heroPortraitBoxRight.TabIndex = 21;
            this.heroPortraitBoxRight.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 658);
            this.Controls.Add(this.heroPortraitBoxRight);
            this.Controls.Add(this.heroPortraitBoxLeft);
            this.Controls.Add(this.powerPercentLabel);
            this.Controls.Add(this.durabilityPercentLabel);
            this.Controls.Add(this.speedPercentLabel);
            this.Controls.Add(this.strengthPercentLabel);
            this.Controls.Add(this.combatPercentLabel);
            this.Controls.Add(this.intelligencePercentLabel);
            this.Controls.Add(this.combatBar);
            this.Controls.Add(this.strengthBar);
            this.Controls.Add(this.durabilityBar);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.powerBar);
            this.Controls.Add(this.intelligenceBar);
            this.Controls.Add(this.combatLabel);
            this.Controls.Add(this.durabilityLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.intelligenceLabel);
            this.Controls.Add(this.heroSearchBox);
            this.Controls.Add(this.searchButton);
            this.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.heroPortraitBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroPortraitBoxRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox heroSearchBox;
        private System.Windows.Forms.Label intelligenceLabel;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label durabilityLabel;
        private System.Windows.Forms.Label combatLabel;
        private System.Windows.Forms.ProgressBar intelligenceBar;
        private System.Windows.Forms.ProgressBar powerBar;
        private System.Windows.Forms.ProgressBar speedBar;
        private System.Windows.Forms.ProgressBar durabilityBar;
        private System.Windows.Forms.ProgressBar strengthBar;
        private System.Windows.Forms.ProgressBar combatBar;
        private System.Windows.Forms.Label intelligencePercentLabel;
        private System.Windows.Forms.Label combatPercentLabel;
        private System.Windows.Forms.Label strengthPercentLabel;
        private System.Windows.Forms.Label speedPercentLabel;
        private System.Windows.Forms.Label durabilityPercentLabel;
        private System.Windows.Forms.Label powerPercentLabel;
        private System.Windows.Forms.PictureBox heroPortraitBoxLeft;
        private System.Windows.Forms.PictureBox heroPortraitBoxRight;
    }
}

