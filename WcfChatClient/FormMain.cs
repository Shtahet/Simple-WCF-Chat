using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfChatClient.ChatService;

namespace WcfChatClient
{
	public partial class FormMain : Form, IChatServiceCallback
	{
		private ChatUser myUserObj;
		ChatServiceClient proxy;

		public FormMain()
		{
			InitializeComponent();

			//Создание прокси класса с дуплексным контрактом
			InstanceContext instance = new InstanceContext(this);
			proxy = new ChatServiceClient(instance);
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			var btn = sender as Button;
			if (btn.Text == "Connect")
			{
				if (ConnectTo() == true)
				{
					btn.Text = "Disconnect";
					txtUserName.Enabled = false;
					txtMessage.Enabled = true;
					btnSend.Enabled = true;
				}
			}
			else
			{
				btn.Text = "Connect";
				DisconnectFrom();
				txtUserName.Enabled = true;
				txtMessage.Enabled = false;
				btnSend.Enabled = false;
			}

		}
		private bool ConnectTo()
		{
			//Проверка введенного имени пользователя
			if (String.IsNullOrEmpty(txtUserName.Text))
			{
				MessageBox.Show("Укажите свой никнейм", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			//Отправка запроса на подключение
			myUserObj = proxy.Login(txtUserName.Text);
			
			return true;
		}

		private void DisconnectFrom()
		{
			proxy.Logout(myUserObj);
		}

		#region Реализация IChatServiceCallback
		public void DeliverMessage (ChatMessage newMsg)
		{

		}

		public void User(ChatUser user, UserActions action)
		{

		}

		public void ReciveAllUsers(List<ChatUser> users)
		{

		}
		#endregion

		private void btnSend_Click(object sender, EventArgs e)
		{
			//Отправка сообщения
			ChatMessage newMessage = new ChatMessage()
			{
				FromUser = myUserObj,
				ToUser = null,
				Message = txtMessage.Text,
				Date = DateTime.Now
			};

			proxy.SendMessage(newMessage);

			txtMessage.Clear();
		}
	}
}
