using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Net;

namespace WcfServiceConsole
{
	[DataContract]
	class ChatUser:IEquatable<ChatUser>
	{
		[DataMember]
		public string NickName { get; set; }
		[DataMember]
		public IPAddress NetworkAddress { get; set; }

		public bool Equals(ChatUser other)
		{
			if (other == null)
				return false;

			return other.NickName == this.NickName && other.NetworkAddress == this.NetworkAddress;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			ChatUser tmpUser = obj as ChatUser;
			if (tmpUser == null)
				return false;

			return Equals(tmpUser);
		}

		public override string ToString()
		{
			return NickName;
		}
	}
}
