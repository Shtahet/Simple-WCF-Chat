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
		private Dictionary<ChatUser, IChatCallbackService> callList = 
			new Dictionary<ChatUser, IChatCallbackService>();
		public ChatUser Login(string name)
		{
			//Получение IP-адреса клиента
			OperationContext currContext = OperationContext.Current;
			MessageProperties msgProp = currContext.IncomingMessageProperties;
			RemoteEndpointMessageProperty endpoint = msgProp[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
			IPAddress clientAddress = IPAddress.Parse(endpoint.Address);

			ChatUser newUser = new ChatUser()
			{
				NickName = name,
				NetworkAddress = clientAddress
			};

			//Проверка на существование пользователя
			if (!conectedUsers.Contains(newUser))
			{
				//Добавление пользователя к общему списку
				conectedUsers.Add(newUser);

				//Добавление канала обратного вызова
				IChatCallbackService currCallBack = OperationContext.Current.GetCallbackChannel<IChatCallbackService>();
				callList.Add(newUser, currCallBack);

				//Логирование подключения
				Console.WriteLine($"Пользователь {newUser.NickName} (IP:{newUser.NetworkAddress}) присоединился к чату");

				//Отправка уведомления другим пользователям
				ChatMessage joinMsg = new ChatMessage()
				{
					FromUser = newUser,
					ToUser = null,
					Message = $"{newUser.NickName} присоединился к чату",
					Date = DateTime.Now
				};
				SendMessage(joinMsg);

				//Отправка подключенным пользователям информации о новом
				foreach (var icall in callList)
				{
					if (icall.Key == newUser)
						continue;

					icall.Value.User(newUser, UserActions.Join);
				}

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
