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
    public partial class Form1 : Form
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
            Directory.CreateDirectory(Environment.CurrentDirectory + @"\output");
            stopwatchTimer = new Stopwatch();
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
        }
    }
}
