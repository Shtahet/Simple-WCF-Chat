using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Net;

namespace WcfServiceConsole
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
	class ChatService : IChatService
	{
		private List<ChatUser> conectedUsers = new List<ChatUser>();
		public ChatUser Login(string name)
		{
			//Получение IP-адреса клиента
			OperationContext currContext = OperationContext.Current;
			MessageProperties msgProp = currContext.IncomingMessageProperties;
			RemoteEndpointMessageProperty endpoint = msgProp[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
			IPAddress clientAddress = IPAddress.Parse(endpoint.Address);

			//Проверка наличия адреса в списке подключенных
			var exists = from e in conectedUsers
						 where e.NetworkAddress == clientAddress
						 select e;

			//Добавление нового пользователя
			if (exists.Count() != 0)
			{
				ChatUser newUser = new ChatUser()
				{
					NickName = name,
					NetworkAddress = clientAddress
				};
				conectedUsers.Add(newUser);

				//Логирование подключения
				Console.WriteLine($"Пользователь {newUser.NickName} (IP:{newUser.NickName}) присоединился к чату");

				//Отправка уведомления другим пользователям
				ChatMessage joinMsg = new ChatMessage()
				{
					User = newUser,
					Message = $"{newUser.NickName} присоединился к чату",
					Date = DateTime.Now
				};
				SendMessage(joinMsg);

				return newUser;
			}
			else
			{
				return null;
			}
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
