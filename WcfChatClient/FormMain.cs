using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfChatClient.ChatService;

namespace WcfChatClient
{
	public partial class FormMain : Form, IChatServiceCallback
	{
		private ChatUser Iam;
		ChatServiceClient proxy;

		public FormMain()
		{
			InitializeComponent();

		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			var btn = sender as Button;
			if (btn.Text == "Connect")
			{
				btn.Text = "Disconnect";
				ConnectTo();
			}
			else
			{
				btn.Text = "Connect";
				DisconnectFrom();
			}

		}
		private void ConnectTo()
		{
			if (String.IsNullOrEmpty(txtUserName.Text))
			{
				MessageBox.Show("Укажите свой никнейм", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
		}

		private void DisconnectFrom()
		{

		}
	}
}
