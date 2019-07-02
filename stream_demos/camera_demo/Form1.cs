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

namespace camera_demo
{
    public partial class Form1 : Form
    {

        // collection of available video devices
        private FilterInfoCollection videoDevices;
        // selected video device
        private VideoCaptureDevice videoDevice;

        // TODO: Remove this test var
        private Int64 count = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeVideoDevice();
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
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            videoDevice.Stop();
        }
    }
}
