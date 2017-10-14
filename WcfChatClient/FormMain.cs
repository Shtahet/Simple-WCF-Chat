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
		private ChatUser Iam;
		ChatServiceClient proxy;

		public FormMain()
		{
			InitializeComponent();

			//Создание прокси класса с дуплексным контрактом
			InstanceContext instance = new InstanceContext(this);
			proxy = new ChatServiceClient(instance);
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			var btn = sender as Button;
			if (btn.Text == "Connect")
			{
				if (ConnectTo() == true)
				{
					btn.Text = "Disconnect";
				}
			}
			else
			{
				btn.Text = "Connect";
				DisconnectFrom();
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
			
			return true;
		}

		private void DisconnectFrom()
		{

		}
	}
}
