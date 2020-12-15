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
        bool isRecorded;
        // User not null if send to user
        User user;
        UserForm userForm;
        // Group not null if send to group
        Group group;
        GroupForm groupForm;

        public ucVoicePanel()
        {
            InitializeComponent();
            voice = new VoiceControl();
        }
        public ucVoicePanel(User user, UserForm userForm)
        {
            InitializeComponent();
            this.user = user;
            this.userForm = userForm;
            voice = new VoiceControl(user);
            voice.Path = voice.GetNextPath();
            isRecorded = false;
        }
        public ucVoicePanel(Group group, GroupForm groupForm)
        {
            InitializeComponent();
            this.group = group;
            this.groupForm = groupForm;
            voice = new VoiceControl(group);
            voice.Path = voice.GetNextPath();
            isRecorded = false;
        }

        private async void pictureBoxSend_Click(object sender, EventArgs e)
        {
            if (voice.GetWave() == null) return;
            voice.DisposeAll();
            byte[] data = File.ReadAllBytes(voice.Path);
            Guid id = new Guid();
            if(user != null)
            {
                byte[] tempBuff = Encoding.UTF8.GetBytes(string.Format("STARTSENDVOICE%{0}%{1}%{2}%{3}%{4}",
                                                                                        Form1.me.Id, user.Id, 
                                                                                        data.Length,
                                                                                        id.ToString(), "Private"));
                SmallPackage smallPackage = new SmallPackage(0, 1024, "V", tempBuff, "0");
                Form1.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);
                Form1.client.SendFileToServer(data, "V", id.ToString());

                ucVoiceMessage voiceMessage = new ucVoiceMessage(user, voice.Path, userForm.messageFocus);
                userForm.AddVoiceMessage(voiceMessage);
                userForm.Controls.Remove(this);
            }
            else
            {
                byte[] tempBuff = Encoding.UTF8.GetBytes(string.Format("STARTSENDVOICE%G{0}%{1}%{2}%{3}%{4}", 
                                                                                        group.ID, 
                                                                                        Form1.me.Id,data.Length,
                                                                                        id.ToString(), "Public"));
                SmallPackage smallPackage = new SmallPackage(0, 1024, "V", tempBuff, "0");
                Form1.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);
                await Form1.client.SendFileToServer(data, "V", id.ToString());

                ucVoiceMessage voiceMessage = new ucVoiceMessage(user, voice.Path, userForm.messageFocus);
                userForm.AddVoiceMessage(voiceMessage);
                userForm.Controls.Remove(this);
            }
            // Process when record sent
            isRecorded = false;
            voice.Path = voice.GetNextPath();
        }

        private void pictureBoxRecording_Click(object sender, EventArgs e)
        {
            if (!isRecorded)
                voice.StartRecording();
            else
                voice.PlayRecording(voice.Path);
        }

        private void pictureBoxStop_Click(object sender, EventArgs e)
        {
            voice.StopRecording();
            isRecorded = true;
        }
    }
}
