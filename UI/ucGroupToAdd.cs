using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
	public partial class ucGroupToAdd : UserControl
	{
		public Group group;
		public AddUserToGroup addUserToGroup;
		public ucGroupToAdd()
		{
			InitializeComponent();
		}
		public ucGroupToAdd(Group group, AddUserToGroup addUserToGroup)
		{
			InitializeComponent();
			this.Dock = DockStyle.Top;
			this.label1.Text = group.Name;
			this.label2.Text = group.ID;
			this.group = group;
			this.addUserToGroup = addUserToGroup;
		}
		public void Reset()
        {
			button1.Text = "ADD";
        }
        private void button1_Click(object sender, EventArgs e)
        {
			if (button1.Text == "ADD")
			{
				addUserToGroup.listAdd.Add(group);
				button1.Text = "CANCEL";
			}
			else
			{
				addUserToGroup.listAdd.Remove(group);
				button1.Text = "ADD";
			}
		}
    }
}
