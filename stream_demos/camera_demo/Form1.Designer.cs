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
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewBox
            // 
            this.PreviewBox.Location = new System.Drawing.Point(143, 97);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(432, 248);
            this.PreviewBox.TabIndex = 0;
            this.PreviewBox.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(73, 380);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(666, 371);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ElapsedTimeBox
            // 
            this.ElapsedTimeBox.Location = new System.Drawing.Point(655, 38);
            this.ElapsedTimeBox.Name = "ElapsedTimeBox";
            this.ElapsedTimeBox.Size = new System.Drawing.Size(100, 20);
            this.ElapsedTimeBox.TabIndex = 3;
            // 
            // ElapsedTimeLabel
            // 
            this.ElapsedTimeLabel.AutoSize = true;
            this.ElapsedTimeLabel.Location = new System.Drawing.Point(652, 22);
            this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            this.ElapsedTimeLabel.Size = new System.Drawing.Size(93, 13);
            this.ElapsedTimeLabel.TabIndex = 4;
            this.ElapsedTimeLabel.Text = "Elapsed Time (ms)";
            // 
            // FPSLabel
            // 
            this.FPSLabel.AutoSize = true;
            this.FPSLabel.Location = new System.Drawing.Point(652, 81);
            this.FPSLabel.Name = "FPSLabel";
            this.FPSLabel.Size = new System.Drawing.Size(60, 13);
            this.FPSLabel.TabIndex = 6;
            this.FPSLabel.Text = "frames/sec";
            // 
            // FPSBox
            // 
            this.FPSBox.Location = new System.Drawing.Point(655, 97);
            this.FPSBox.Name = "FPSBox";
            this.FPSBox.Size = new System.Drawing.Size(100, 20);
            this.FPSBox.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // CameraDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FPSLabel);
            this.Controls.Add(this.FPSBox);
            this.Controls.Add(this.ElapsedTimeLabel);
            this.Controls.Add(this.ElapsedTimeBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PreviewBox);
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
    }
}

