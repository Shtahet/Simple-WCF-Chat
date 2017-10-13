using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceConsole
{
	[DataContract]
	class ChatMessage
	{
		[DataMember]
		public ChatUser FromUser { get; set; }
		[DataMember]
		public ChatUser ToUser { get; set; }
		[DataMember]
		public string Message { get; set; }
		[DataMember]
		public DateTime Date { get; set; }
	}
}
