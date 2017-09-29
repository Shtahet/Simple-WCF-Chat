using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfServiceConsole
{
	[ServiceContract]
	interface IChatService
	{
		[OperationContract]
		void Login(string name);
		[OperationContract]
		void Logout(string name);
	}
}
