using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfServiceConsole
{
	[ServiceContract(SessionMode = SessionMode.Required)]
	interface IChatService
	{
		[OperationContract(IsInitiating = true, IsTerminating = false)]
		ChatUser Login(string name);
		[OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = true)]
		void Logout(ChatUser name);
		[OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
		void SendMessage(ChatMessage msg);
	}
}
