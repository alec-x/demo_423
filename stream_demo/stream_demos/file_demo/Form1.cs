using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            var bufferArray = new byte[1000];
            FileStream fileToRead = File.Open(pathBox.Text, FileMode.Open);
            fileToRead.Read(bufferArray, 0, 1000);
            fileToRead.Close();
            // ToString doesn't work here
            contentBox.Text = System.Text.Encoding.Default.GetString(bufferArray);

        }

        private void writeButton_Click(object sender, EventArgs e)
        {
        }
    }
}
