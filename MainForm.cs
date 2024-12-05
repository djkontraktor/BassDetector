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
using SharpDX.XAudio2;
using SharpDX.Multimedia;
using System.IO;
using SharpDX;

namespace BassDetector
{
    public partial class MainForm : Form
    {

        private WasapiLoopbackCapture mWasapiLoopbackCapture;
        private BufferedWaveProvider mBufferedWaveProvider;
        private bool mLedOn = false;
        private float mAmplitudeTriggerThreshold = 0.0005F;
        private float mCutoffFreq_Low_Hz = 30;
        private float mCutoffFreq_High_Hz = 90;
        private Enums.Humidity mHumidity = Enums.Humidity.Dry;
        private Enums.WaveLength mWaveLength = Enums.WaveLength.Short;

        public MainForm()
        {
            InitializeComponent();

            mWasapiLoopbackCapture = new WasapiLoopbackCapture();
            mBufferedWaveProvider = new BufferedWaveProvider(mWasapiLoopbackCapture.WaveFormat);

            mWasapiLoopbackCapture.DataAvailable += (s, a) =>
            {
                mBufferedWaveProvider.AddSamples(a.Buffer, 0, a.BytesRecorded);
            };

            mWasapiLoopbackCapture.StartRecording();

            Timer timer = new Timer
            {
                Interval = 10
            };
            timer.Tick += AnalyzeAudio;
            timer.Start();
        }

        private void PlaySound()
        {
            string fileName = PathMgt.ReturnRandomWaveFile(mHumidity, mWaveLength);

            XAudio2 xAudio2 = new XAudio2();

            MasteringVoice masteringVoice = new MasteringVoice(xAudio2);

            SharpDX.Multimedia.WaveFormat waveFormat = new SharpDX.Multimedia.WaveFormat(44100, 16, 2);

            AudioBuffer audioBuffer = new AudioBuffer
            {
                Stream = new DataStream(File.ReadAllBytes(fileName).Length, true, false),
                AudioBytes = (int)new FileInfo(fileName).Length,
                Flags = BufferFlags.EndOfStream
            };

            SourceVoice sourceVoice = new SourceVoice(xAudio2, waveFormat);

            sourceVoice.SubmitSourceBuffer(audioBuffer, null);

            sourceVoice.Start();
        }

        private void AnalyzeAudio(object sender, EventArgs e)
        {
            byte[] byteBuffer = new byte[mBufferedWaveProvider.BufferLength];

            mBufferedWaveProvider.Read(byteBuffer, 0, mBufferedWaveProvider.BufferLength);

            float[] audioData = new float[byteBuffer.Length / 4];

            for (int i = 0; i < audioData.Length; i++)
            {
                audioData[i] = BitConverter.ToSingle(byteBuffer, i * 4);
            }

            Complex[] fftBuffer = new Complex[audioData.Length];

            for (int i = 0; i < audioData.Length; i++)
            {
                fftBuffer[i].X = (float)(audioData[i] * FastFourierTransform.HammingWindow(i, audioData.Length));
                fftBuffer[i].Y = 0;
            }

            FastFourierTransform.FFT(true, (int)Math.Log(audioData.Length, 2.0), fftBuffer);

            int sampleRate = mWasapiLoopbackCapture.WaveFormat.SampleRate;
            int lowIndex = (int)(mCutoffFreq_Low_Hz / sampleRate * audioData.Length);
            int highIndex = (int)(mCutoffFreq_High_Hz / sampleRate * audioData.Length);

            float amplitude = 0;

            for (int i = lowIndex; i <= highIndex; i++)
            {
                amplitude += fftBuffer[i].X * fftBuffer[i].X + fftBuffer[i].Y * fftBuffer[i].Y;
            }

            amplitude = (float)Math.Sqrt(amplitude);

            if (amplitude >= mAmplitudeTriggerThreshold)
            {
                if (!mLedOn)
                {
                    mLedOn = true;
                    ledPictureBox.BackColor = Color.Green;
                    PlaySound();
                }
            }
            else
            {
                if (mLedOn)
                {
                    mLedOn = false;
                    ledPictureBox.BackColor = Color.Black;
                }
            }
        }
    }
}
