namespace file_demo
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
            this.pathBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.contentBox = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.readButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.fileSelectDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // pathBox
            // 
            this.pathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathBox.Location = new System.Drawing.Point(13, 14);
            this.pathBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(565, 39);
            this.pathBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(586, 14);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(119, 39);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(12, 100);
            this.contentBox.Multiline = true;
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(693, 277);
            this.contentBox.TabIndex = 4;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(8, 77);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(103, 20);
            this.contentLabel.TabIndex = 5;
            this.contentLabel.Text = "File contents";
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(526, 383);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(87, 41);
            this.readButton.TabIndex = 6;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(619, 383);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(87, 41);
            this.writeButton.TabIndex = 7;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            // 
            // fileSelectDialog
            // 
            this.fileSelectDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 431);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.pathBox);
            this.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "File Stream Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox contentBox;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.OpenFileDialog fileSelectDialog;
    }
}

