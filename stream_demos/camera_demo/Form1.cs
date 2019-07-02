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
        // Output directory
        private string outputDir = Environment.CurrentDirectory + @"\output";
        // TODO: Remove test vars
        private Int64 count = 0;
        private Int64 averageFPSCount = 0;
        private Stopwatch elapsedTimeWatch;
        private Stopwatch fpsWatch;
        public CameraDemoForm()
        {
            InitializeComponent();
            InitializeVideoDevice();
            
            EmptyDirectory(outputDir);
            Directory.CreateDirectory(outputDir);
            elapsedTimeWatch = new Stopwatch();
            fpsWatch = new Stopwatch();
            
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
            string name = prefix + @"\output\" + "capture" + count + ".bmp";
            newFrame.Save(name, System.Drawing.Imaging.ImageFormat.Bmp);
            count++;
            
            PreviewBox.Image = Image.FromFile(name);
            averageFPSCount++;

            return;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            EmptyDirectory(outputDir);
            videoDevice.Start();
            elapsedTimeWatch.Start();
            fpsWatch.Start();
            timer1.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            videoDevice.Stop();
            
            elapsedTimeWatch.Stop();
            elapsedTimeWatch.Reset();

            fpsWatch.Stop();
            fpsWatch.Reset();
            
            count = 0;
            averageFPSCount = 0;
        }

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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // update FPS
            if (fpsWatch.ElapsedMilliseconds >= 500)
            {
                FPSBox.Text = (averageFPSCount * 1000 / fpsWatch.ElapsedMilliseconds).ToString();
                fpsWatch.Restart();
                averageFPSCount = 0;
            }

            // update elapsed time
            ElapsedTimeBox.Text = elapsedTimeWatch.ElapsedMilliseconds.ToString();
        }
    }
}
