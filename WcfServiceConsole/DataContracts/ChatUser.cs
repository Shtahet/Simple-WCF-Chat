using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Net;

namespace WcfServiceConsole.DataContracts
{
	[DataContract]
	class ChatUser
	{
		[DataMember]
		public string NickName { get; set; }
		[DataMember]
		public IPAddress NetworkAddress { get; set; }
		public override string ToString()
		{
			return NickName;
		}
	}
}
