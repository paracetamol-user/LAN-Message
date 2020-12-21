using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;
using Network;

namespace UI
{
	public partial class ucVoicePanel : UserControl
	{
		VoiceControl voice;
		// User not null if send to user
		User user;
		UserForm userForm;
		// Group not null if send to group
		Group group;
		GroupForm groupForm;
		// Check valid for send (>= 1s)
		private Timer timer;
		private bool isValidForSend;

		public ucVoicePanel()
		{
			InitializeComponent();
			voice = new VoiceControl();
		}
		public ucVoicePanel(User user, UserForm userForm)
		{
			InitializeComponent();
			InitPictureBox();
			this.user = user;
			this.userForm = userForm;
			voice = new VoiceControl(user);
			voice.Path = voice.GetNextPath();
			timer = new Timer();
			timer.Tick += Timer_Tick;
			timer.Interval = 1000;
			this.panelRecord.Controls.Add(pctRecord);
		}
		public ucVoicePanel(Group group, GroupForm groupForm)
		{
			InitializeComponent();
			InitPictureBox();
			this.group = group;
			this.groupForm = groupForm;
			voice = new VoiceControl(group);
			voice.Path = voice.GetNextPath();
			timer = new Timer();
            timer.Tick += Timer_Tick;
			timer.Interval = 1000;
			this.panelRecord.Controls.Add(pctRecord);
		}

        private void Timer_Tick(object sender, EventArgs e)
        {
			isValidForSend = true;
			timer.Stop();
        }

        PictureBox pctRecord, pctStop, pctSend, pctBin, pctPlay;
		private void InitPictureBox()
        {
			pctRecord = new PictureBox();
			pctRecord.Dock = DockStyle.Fill;
			pctRecord.Image = Image.FromFile(Form1.theme.pictureRecord);
			pctRecord.SizeMode = PictureBoxSizeMode.Zoom;
            pctRecord.Click += PctRecord_Click;

			pctStop = new PictureBox();
			pctStop.Dock = DockStyle.Fill;
			pctStop.Image = Image.FromFile(Form1.theme.pictureStop);
			pctStop.SizeMode = PictureBoxSizeMode.Zoom;
			pctStop.Click += PctStop_Click;

			pctSend = new PictureBox();
			pctSend.Dock = DockStyle.Fill;
			pctSend.Image = Image.FromFile(Form1.theme.pictureSend);
			pctSend.SizeMode = PictureBoxSizeMode.Zoom;
			pctSend.Click += PctSend_Click;

			pctBin = new PictureBox();
			pctBin.Dock = DockStyle.Fill;
			pctBin.Image = Image.FromFile(Form1.theme.pictureBin);
			pctBin.SizeMode = PictureBoxSizeMode.Zoom;
			pctBin.Click += PctBin_Click;

			pctPlay = new PictureBox();
			pctPlay.Image = Image.FromFile(Form1.theme.picturePlay);
			pctPlay.SizeMode = PictureBoxSizeMode.Zoom;
			pctPlay.Dock = DockStyle.Fill;
            pctPlay.Click += PctPlay_Click;
        }

		// Event for click
        private void PctPlay_Click(object sender, EventArgs e)
        {
			voice.PlayRecording(voice.Path);
        }
        private void PctBin_Click(object sender, EventArgs e)
        {
			voice.DisposeAll();
			File.Delete(voice.Path);

			this.panelRecord.Controls.Remove(pctPlay);
			this.panelRecord.Controls.Add(pctRecord);
			this.PanelDelete.Controls.Remove(pctBin);
			this.PanelSend.Controls.Remove(pctSend);
			isValidForSend = false;	
        }
        private void PctSend_Click(object sender, EventArgs e)
        {
			// Send voice to server
			SendVoiceToServer();

			this.PanelSend.Controls.Remove(pctSend);
			this.PanelDelete.Controls.Remove(pctBin);
			this.panelRecord.Controls.Remove(pctPlay);
			this.panelRecord.Controls.Add(pctRecord);
			this.Visible = false;
			if (userForm != null) userForm.isVoicePanelShow = false;
			else groupForm.isVoicePanelShow = false;
			isValidForSend = false;
        }
        private void PctStop_Click(object sender, EventArgs e)
        {
			if (!isValidForSend) return;
			voice.StopRecording();

			this.panelRecord.Controls.Remove(pctStop);
			this.panelRecord.Controls.Add(pctPlay);
			this.PanelDelete.Controls.Add(pctBin);
			this.PanelSend.Controls.Add(pctSend);
        }
        private void PctRecord_Click(object sender, EventArgs e)
        {
			this.panelRecord.Controls.Remove(pctRecord);
			this.panelRecord.Controls.Add(pctStop);

			voice.StartRecording();
			timer.Start();
        }

		private async void SendVoiceToServer()
        {
			if (voice.GetWave() == null) return;
			voice.DisposeAll();

			byte[] data = File.ReadAllBytes(voice.Path);
			Guid id = new Guid();
			if (user != null)
			{
				byte[] tempBuff = Encoding.UTF8.GetBytes(string.Format("STARTSENDVOICE%{0}%{1}%{2}%{3}",
																						user.Id,
																						data.Length,
																						id.ToString(), "Private"));
				SmallPackage smallPackage = new SmallPackage(0, 1024, "M", tempBuff, "0");
				Form1.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);
				Form1.client.SendFileToServer(data, "V", id.ToString());

				userForm.AddVoiceMessage(Form1.me, voice.Path);
			}
			else
			{
				byte[] tempBuff = Encoding.UTF8.GetBytes(string.Format("STARTSENDVOICE%{0}%{1}%{2}%{3}",
																						group.ID,
																						data.Length,
																						id.ToString(), "Public"));
				SmallPackage smallPackage = new SmallPackage(0, 1024, "M", tempBuff, "0");
				Form1.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);
				Form1.client.SendFileToServer(data, "V", id.ToString());

				groupForm.AddVoiceMessage(Form1.me, voice.Path);
			}
			// Process when record sent
			voice.Path = voice.GetNextPath();
		}
	}
}
