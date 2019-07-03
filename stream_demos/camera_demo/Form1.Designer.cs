namespace camera_demo
{
    partial class CameraDemoForm
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
            this.components = new System.ComponentModel.Container();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ElapsedTimeBox = new System.Windows.Forms.TextBox();
            this.ElapsedTimeLabel = new System.Windows.Forms.Label();
            this.FPSLabel = new System.Windows.Forms.Label();
            this.FPSBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SelectLabel = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.SelectCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewBox
            // 
            this.PreviewBox.Location = new System.Drawing.Point(11, 14);
            this.PreviewBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(624, 394);
            this.PreviewBox.TabIndex = 0;
            this.PreviewBox.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(11, 433);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(210, 89);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(229, 433);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(195, 89);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ElapsedTimeBox
            // 
            this.ElapsedTimeBox.Location = new System.Drawing.Point(645, 37);
            this.ElapsedTimeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ElapsedTimeBox.Name = "ElapsedTimeBox";
            this.ElapsedTimeBox.Size = new System.Drawing.Size(212, 26);
            this.ElapsedTimeBox.TabIndex = 3;
            // 
            // ElapsedTimeLabel
            // 
            this.ElapsedTimeLabel.AutoSize = true;
            this.ElapsedTimeLabel.Location = new System.Drawing.Point(641, 13);
            this.ElapsedTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            this.ElapsedTimeLabel.Size = new System.Drawing.Size(140, 20);
            this.ElapsedTimeLabel.TabIndex = 4;
            this.ElapsedTimeLabel.Text = "Elapsed Time (ms)";
            // 
            // FPSLabel
            // 
            this.FPSLabel.AutoSize = true;
            this.FPSLabel.Location = new System.Drawing.Point(641, 104);
            this.FPSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FPSLabel.Name = "FPSLabel";
            this.FPSLabel.Size = new System.Drawing.Size(87, 20);
            this.FPSLabel.TabIndex = 6;
            this.FPSLabel.Text = "frames/sec";
            // 
            // FPSBox
            // 
            this.FPSBox.Location = new System.Drawing.Point(645, 128);
            this.FPSBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FPSBox.Name = "FPSBox";
            this.FPSBox.Size = new System.Drawing.Size(212, 26);
            this.FPSBox.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Location = new System.Drawing.Point(642, 434);
            this.SelectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(57, 20);
            this.SelectLabel.TabIndex = 8;
            this.SelectLabel.Text = "Device";
            // 
            // SelectButton
            // 
            this.SelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.Location = new System.Drawing.Point(781, 489);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(74, 33);
            this.SelectButton.TabIndex = 9;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // SelectCombo
            // 
            this.SelectCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCombo.FormattingEnabled = true;
            this.SelectCombo.Location = new System.Drawing.Point(646, 458);
            this.SelectCombo.Name = "SelectCombo";
            this.SelectCombo.Size = new System.Drawing.Size(211, 23);
            this.SelectCombo.TabIndex = 10;
            this.SelectCombo.Click += new System.EventHandler(this.SelectCombo_Click);
            // 
            // CameraDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 553);
            this.Controls.Add(this.SelectCombo);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.FPSLabel);
            this.Controls.Add(this.FPSBox);
            this.Controls.Add(this.ElapsedTimeLabel);
            this.Controls.Add(this.ElapsedTimeBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PreviewBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CameraDemoForm";
            this.Text = "Video Stream Demo";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox ElapsedTimeBox;
        private System.Windows.Forms.Label ElapsedTimeLabel;
        private System.Windows.Forms.Label FPSLabel;
        private System.Windows.Forms.TextBox FPSBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.ComboBox SelectCombo;
    }
}

