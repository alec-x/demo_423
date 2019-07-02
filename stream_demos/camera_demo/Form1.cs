using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Video.DirectShow;
using Accord.Video;
using System.IO;
using System.Diagnostics;
namespace camera_demo
{
    public partial class CameraDemoForm : Form
    {

        // collection of available video devices
        private FilterInfoCollection videoDevices;
        // selected video device
        private VideoCaptureDevice videoDevice;

        // TODO: Remove test vars
        private Int64 count = 0;
        private Int64 timer = 0;
        private Stopwatch stopwatchTimer;
        public Form1()
        {
            InitializeComponent();
            InitializeVideoDevice();
            stopwatchTimer = new Stopwatch();
            string outputDir = Environment.CurrentDirectory + @"\output";
            EmptyDirectory(outputDir);
            Directory.CreateDirectory(outputDir);
        }

        public void InitializeVideoDevice()
        {
            // Find first valid video input device (ie. webcam) and assign as videodevice
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoDevice = new VideoCaptureDevice(videoDevices[1].MonikerString);
            videoDevice.NewFrame += new NewFrameEventHandler(FrameHandler);
        }

        private void FrameHandler(object sender, NewFrameEventArgs args)
        {
            Bitmap newFrame = args.Frame;
            string prefix = Environment.CurrentDirectory;
            string name = prefix + @"\output\" + "lol" + count + ".bmp";
            newFrame.Save(name, System.Drawing.Imaging.ImageFormat.Bmp);
            count++;
                
            //PreviewBox.Image = newFrame;
            return;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            videoDevice.Start();
            stopwatchTimer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            videoDevice.Stop();
            stopwatchTimer.Stop();
            ElapsedTimeBox.Text = (count * 1000 / stopwatchTimer.ElapsedMilliseconds).ToString();
            stopwatchTimer.Reset();
            count = 0;
        private static void EmptyDirectory(string dir)
        {
            try
            {
                System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(dir);
                foreach (System.IO.FileInfo file in directory.EnumerateFiles())
                {
                    file.Delete();
                }

                foreach (System.IO.DirectoryInfo subDirectory in directory.EnumerateDirectories())
                {
                    subDirectory.Delete(true);
                }
            }
            catch
            {
                MessageBox.Show("Error, either invalid directory path or permissions issue");
            }
            return;
        }
        }
    }
}
