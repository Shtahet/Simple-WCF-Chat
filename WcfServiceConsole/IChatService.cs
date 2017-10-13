using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfServiceConsole
{
	[ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IChatCallbackService))]
	interface IChatService
	{
		[OperationContract(IsInitiating = true, IsTerminating = false)]
		ChatUser Login(string name);

		[OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = true)]
		void Logout(ChatUser name);

		[OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
		void SendMessage(ChatMessage msg);
	}

	interface IChatCallbackService
	{
		[OperationContract(IsOneWay = true)]
		void DeliverMessage(ChatMessage msg);

		[OperationContract(IsOneWay = true)]
		void User(ChatUser user, UserActions action);

		[OperationContract(IsOneWay = true)]
		void ReciveAllUsers(List<ChatUser> users);
	}
}
