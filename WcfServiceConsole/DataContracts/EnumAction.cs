using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceConsole
{
	[DataContract]
	enum UserActions
	{
		[EnumMember]
		Join,
		[EnumMember]
		Left
	}
}
