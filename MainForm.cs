using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Dsp;

namespace BassDetector
{
    public partial class MainForm : Form
    {

        private WasapiLoopbackCapture capture;
        private BufferedWaveProvider buffer;
        private Timer timer;
        private bool ledOn = false;
        private float A = 0.0015F;
        private float fLow = 30;
        private float fHigh = 90;

        public MainForm()
        {
            InitializeComponent();

            // Set up audio capture
            capture = new WasapiLoopbackCapture();
            buffer = new BufferedWaveProvider(capture.WaveFormat);

            capture.DataAvailable += (s, a) =>
            {
                buffer.AddSamples(a.Buffer, 0, a.BytesRecorded);
            };

            capture.StartRecording();

            // Set up timer for analysis
            timer = new Timer
            {
                Interval = 10 // Check every 100 milliseconds
            };
            timer.Tick += AnalyzeAudio;
            timer.Start();
        }

        private void AnalyzeAudio(object sender, EventArgs e)
        {
            byte[] byteBuffer = new byte[buffer.BufferLength];
            buffer.Read(byteBuffer, 0, buffer.BufferLength);

            // Convert byte array to float array
            float[] audioData = new float[byteBuffer.Length / 4];
            for (int i = 0; i < audioData.Length; i++)
            {
                audioData[i] = BitConverter.ToSingle(byteBuffer, i * 4);
            }

            // Apply FFT
            Complex[] fftBuffer = new Complex[audioData.Length];
            for (int i = 0; i < audioData.Length; i++)
            {
                fftBuffer[i].X = (float)(audioData[i] * FastFourierTransform.HammingWindow(i, audioData.Length));
                fftBuffer[i].Y = 0;
            }

            FastFourierTransform.FFT(true, (int)Math.Log(audioData.Length, 2.0), fftBuffer);

            // Analyze specific frequency band
            int sampleRate = capture.WaveFormat.SampleRate;
            int lowIndex = (int)(fLow / sampleRate * audioData.Length);
            int highIndex = (int)(fHigh / sampleRate * audioData.Length);

            float amplitude = 0;
            for (int i = lowIndex; i <= highIndex; i++)
            {
                amplitude += fftBuffer[i].X * fftBuffer[i].X + fftBuffer[i].Y * fftBuffer[i].Y;
            }
            amplitude = (float)Math.Sqrt(amplitude);

            // Turn LED on or off based on amplitude
            if (amplitude >= A)
            {
                ledOn = true;
                ledPictureBox.BackColor = Color.Green;
            }
            else
            {
                ledOn = false;
                ledPictureBox.BackColor = Color.Black;
            }
        }
    }
}
