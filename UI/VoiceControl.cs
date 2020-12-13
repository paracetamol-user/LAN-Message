using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using NAudio.Wave;

namespace UI
{
    public class VoiceControl
    {
        private string path = @"..\buffer.wav";
        private WaveIn sourceStream;
        private WaveFileWriter writer;
        private Timer timer;
        int deviceNumber = 0;
        TcpClient client;

        public VoiceControl(TcpClient client)
        {
            this.client = client;
        }

        public void BeginRecord()
        {
            timer = new Timer();
            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                if (WaveIn.GetCapabilities(i).ProductName.Contains("icrophone"))
                    deviceNumber = i;
            }
            timer.Interval = 2000;
            timer.Enabled = false;
            timer.Tick += timer_Tick;
            timer.Start();
        }
        public void StopRecord()
        {
            if (timer != null)
                timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Re
            // Dispose
            Dispose();
            // Send byte array
            SendByte();
        }

        private byte[] buff;
        private void SendByte()
        {
            buff = File.ReadAllBytes(path);
            client.GetStream().WriteAsync(buff, 0, buff.Length);
        }
        private void Dispose()
        {
            if (sourceStream != null)
                sourceStream.Dispose();

            if (writer != null)
                writer.Dispose();
            GC.SuppressFinalize(this);
        }

        private void RecordWAV()
        {
            sourceStream = new WaveIn();

            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new WaveFormat(22000, WaveIn.GetCapabilities(deviceNumber).Channels);
            sourceStream.DataAvailable += new EventHandler<WaveInEventArgs>(sourceStream_DataAvailable);

            writer = new WaveFileWriter(path, sourceStream.WaveFormat);

            sourceStream.StartRecording();
            timer.Start();
        }

        private void sourceStream_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (writer == null) return;

            writer.WriteData(e.Buffer, 0, e.BytesRecorded);
            writer.Flush();
        }
    }
}
