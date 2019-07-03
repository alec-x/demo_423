using System;
using System.IO;
using System.Windows.Forms;

namespace file_demo
{
    public partial class FileDemoForm : Form
    {
        const int bufferSize = 1000;
        public FileDemoForm()
        {
            InitializeComponent();
            contentBox.MaxLength = bufferSize;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            fileSelectDialog.ShowDialog();

            if(fileSelectDialog.FileName.Contains(".txt"))
            {
                pathBox.Text = fileSelectDialog.FileName;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error: Please select a text file");
            }           
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            // Fixed size buffer
            
            var bufferArray = new byte[bufferSize];
            FileStream fileToRead = File.Open(pathBox.Text, FileMode.Open);
            fileToRead.Read(bufferArray, 0, bufferSize);
            fileToRead.Close();

            // ToString doesn't work here
            contentBox.Text = System.Text.Encoding.Default.GetString(bufferArray);

        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            var bufferArray = new byte[bufferSize];
            bufferArray = System.Text.Encoding.Default.GetBytes(contentBox.Text);
            FileStream fileToWrite = File.Open(pathBox.Text, FileMode.Create);
            fileToWrite.Write(bufferArray, 0, bufferArray.Length);
            fileToWrite.Close();
        }
    }
}
