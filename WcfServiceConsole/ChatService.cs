using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfServiceConsole
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
	class ChatService : IChatService
	{
		private List<ChatUser> conectedUsers = new List<ChatUser>();
		public ChatUser Login(string name)
		{
			throw new NotImplementedException();
		}

		public void Logout(ChatUser name)
		{
			throw new NotImplementedException();
		}

		public void SendMessage(ChatMessage msg)
		{
			throw new NotImplementedException();
		}
	}
}
