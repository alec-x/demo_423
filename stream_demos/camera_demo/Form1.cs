using System;
using System.Drawing;
using System.Windows.Forms;
using Accord.Video.DirectShow;
using Accord.Video;
using System.IO;
using System.Diagnostics;

namespace camera_demo
{
    public partial class CameraDemoForm : Form
    {

        // Collection of available video devices
        private FilterInfoCollection videoDevices;
        // Selected video device
        private VideoCaptureDevice videoDevice;
        // Output directory
        private string outputDir = Environment.CurrentDirectory + @"\output\";
        
        // Timekeeping vars, stopwatch is more accurate than timer
        private Int64 count = 0;
        private Int64 averageFPSCount = 0;
        private Stopwatch elapsedTimeWatch;
        private Stopwatch fpsWatch;
        public CameraDemoForm()
        {
            InitializeComponent();

            try
            {
                Directory.Delete(outputDir);
            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine("No directory to delete");
            }
            
            Directory.CreateDirectory(outputDir);

            elapsedTimeWatch = new Stopwatch();
            fpsWatch = new Stopwatch();
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
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

        private void SelectCombo_Click(object sender, EventArgs e)
        {
            // Find first valid video input device (ie. webcam) and assign as videodevice
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            SelectCombo.Items.Clear();
            foreach (var item in videoDevices)
            {
                SelectCombo.Items.Add(item.Name);
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            // Find "Logitech" cameras
            // videoDevice = new VideoCaptureDevice(videoDevices.Find(x => x.Name.Contains("Logitech")).MonikerString);
            try
            {
                // Using lambda function, find device in videodevices matching name of selected combobox item and extract moniker
                string deviceMoniker = videoDevices.Find(x => x.Name.Contains(SelectCombo.SelectedItem.ToString())).MonikerString;
                videoDevice = new VideoCaptureDevice(deviceMoniker);

                // associate new frame event with event handler defined in utilities section
                videoDevice.NewFrame += new NewFrameEventHandler(FrameHandler);
            }
            catch
            {
                MessageBox.Show("Error, device cannot be selected");
                StartButton.Enabled = false;
                StopButton.Enabled = false;
            }

            StartButton.Enabled = true;
            StopButton.Enabled = true;
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

        private void FrameHandler(object sender, NewFrameEventArgs args)
        {
            // Be careful about using ref vs value of args.Frame, depending
            // on how this is done, program may hog access rights to object
            Bitmap newFrame = new Bitmap(args.Frame);
            string name = outputDir + "capture" + count + ".bmp";
            newFrame.Save(name, System.Drawing.Imaging.ImageFormat.Bmp);
            
            PreviewBox.Image = newFrame;
            averageFPSCount++;
            count++;

            return;
        }
    }
}
