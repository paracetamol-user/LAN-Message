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
        }
        public ucVoicePanel(Group group, GroupForm groupForm)
        {
            InitializeComponent();
            this.group = group;
            this.groupForm = groupForm;
            voice = new VoiceControl(group);
        }

        private void pictureBoxSend_Click(object sender, EventArgs e)
        {
            if (voice.GetWave() == null) return;
            byte[] data = File.ReadAllBytes(voice.Path);

        }

        private void pictureBoxRecording_Click(object sender, EventArgs e)
        {
            if (!isRecorded)
                voice.StartRecording();
        }

        private void pictureBoxStop_Click(object sender, EventArgs e)
        {
            voice.StopRecording();
        }
    }
}
