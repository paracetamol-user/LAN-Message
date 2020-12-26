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
		FrmUser userForm;
		// Group not null if send to group
		Group group;
		FrmGroup groupForm;
		// Check valid for send (>= 1s)
		private Timer timer;
		private bool isValidForSend;

		public ucVoicePanel()
		{
			InitializeComponent();
			voice = new VoiceControl();
		}
		public ucVoicePanel(User user, FrmUser userForm)
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
		public ucVoicePanel(Group group, FrmGroup groupForm)
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
		public void InitControls()
		{
			pctRecord.Image = Image.FromFile(FrmMain.theme.pictureRecord);
			pctStop.Image = Image.FromFile(FrmMain.theme.pictureStop);
			pctSend.Image = Image.FromFile(FrmMain.theme.pictureSend);
			pctBin.Image = Image.FromFile(FrmMain.theme.pictureBin);
			pctPlay.Image = Image.FromFile(FrmMain.theme.picturePlay);
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
			pctRecord.Image = Image.FromFile(FrmMain.theme.pictureRecord);
			pctRecord.SizeMode = PictureBoxSizeMode.Zoom;
            pctRecord.Click += PctRecord_Click;

			pctStop = new PictureBox();
			pctStop.Dock = DockStyle.Fill;
			pctStop.Image = Image.FromFile(FrmMain.theme.pictureStop);
			pctStop.SizeMode = PictureBoxSizeMode.Zoom;
			pctStop.Click += PctStop_Click;

			pctSend = new PictureBox();
			pctSend.Dock = DockStyle.Fill;
			pctSend.Image = Image.FromFile(FrmMain.theme.pictureSend);
			pctSend.SizeMode = PictureBoxSizeMode.Zoom;
			pctSend.Click += PctSend_Click;

			pctBin = new PictureBox();
			pctBin.Dock = DockStyle.Fill;
			pctBin.Image = Image.FromFile(FrmMain.theme.pictureBin);
			pctBin.SizeMode = PictureBoxSizeMode.Zoom;
			pctBin.Click += PctBin_Click;

			pctPlay = new PictureBox();
			pctPlay.Image = Image.FromFile(FrmMain.theme.picturePlay);
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
			try
			{
				if (voice.GetWave() == null) return;
				voice.DisposeAll();

				byte[] data = File.ReadAllBytes(voice.Path);
				Guid id = Guid.NewGuid();
				if (user != null)
				{
					byte[] tempBuff = Encoding.UTF8.GetBytes(string.Format("STARTSENDVOICE%{0}%{1}%{2}%{3}",
																							user.Id,
																							data.Length,
																							id.ToString(), "Private"));
					SmallPackage smallPackage = new SmallPackage(0, 1024, "M", tempBuff, "0");
					FrmMain.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);
					FrmMain.client.SendFileToServer(data, "V", id.ToString());

					userForm.AddVoiceMessage(FrmMain.me, voice.Path);
				}
				else
				{
					byte[] tempBuff = Encoding.UTF8.GetBytes(string.Format("STARTSENDVOICE%{0}%{1}%{2}%{3}",
																							group.ID,
																							data.Length,
																							id.ToString(), "Public"));
					SmallPackage smallPackage = new SmallPackage(0, 1024, "M", tempBuff, "0");
					FrmMain.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);
					FrmMain.client.SendFileToServer(data, "V", id.ToString());

					groupForm.AddVoiceMessage(FrmMain.me, voice.Path);
				}
				// Process when record sent
				voice.Path = voice.GetNextPath();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please check the connection again or the server could not be found!", "Error Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
	}
}
