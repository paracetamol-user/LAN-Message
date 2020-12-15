using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using NAudio.Wave;
using UserManager;

namespace UI
{
	public class VoiceControl
	{
		WaveFileWriter writer;
		WaveFileReader reader;
		DirectSoundOut player;
		WaveIn wave;
		private int deviceNumber;
		public int nextID;
		public string Path = @"..\voice_mess\";

		public VoiceControl()
		{
			deviceNumber = 0;
			nextID = 0;
		}
		public VoiceControl(User user)
		{
			deviceNumber = 0;
			if (!Directory.Exists(Path))
				Directory.CreateDirectory(Path);
			Path += string.Format(@"{0}\", user.Id);
			if (!Directory.Exists(Path))
				Directory.CreateDirectory(Path);
			nextID = GetNextID();
		}
		public VoiceControl(Group group)
		{
			deviceNumber = 0;
			if(!Directory.Exists(Path))
				Directory.CreateDirectory(Path);
			Path += string.Format(@"G{0}\", group.ID);
			if (!Directory.Exists(Path))
				Directory.CreateDirectory(Path);
			nextID = GetNextID();
		}

		public WaveIn GetWave() => wave;
		public void StartRecording()
		{
			DisposeAll();
			wave = new WaveIn();

			for (int i = 0; i < WaveIn.DeviceCount; i++)
				if (WaveIn.GetCapabilities(i).ProductName.Contains("icrophone"))
				{
					deviceNumber = i;
					break;
				}

			wave.DeviceNumber = deviceNumber;
			wave.WaveFormat = new WaveFormat(11000, WaveIn.GetCapabilities(deviceNumber).Channels);
			wave.DataAvailable += new EventHandler<WaveInEventArgs>(wave_DataAvailable);

			writer = new WaveFileWriter(Path, wave.WaveFormat);

			wave.StartRecording();
			System.Diagnostics.Debug.WriteLine("Recording");

		}
		private void wave_DataAvailable(object sender, WaveInEventArgs e)
		{
			if (writer == null) return;

			writer.WriteData(e.Buffer, 0, e.BytesRecorded);

			writer.Flush();
		}
		public void StopRecording()
		{
			if (wave == null) return;
			wave.StopRecording();
		}
		public void PlayRecording(int id)
		{
			DisposeAll();
			reader = new WaveFileReader(string.Format("{0}{1}.wav", Path, id));
			player = new DirectSoundOut();
			player.Init(new WaveChannel32(reader));
			player.Play();
		}
		private void DisposeAll()
		{
			if (reader != null)
				reader.Dispose();
			if (writer != null)
				writer.Dispose();
			if (player != null)
				player.Dispose();
		}

		private int GetNextID()
		{
			int id = 0;
			while (true)
			{
				string temp = string.Format(@"{0}{1}.wav", Path, id);
				if (!File.Exists(temp))
					return id;
				id++;
			}
		}
	}
}
