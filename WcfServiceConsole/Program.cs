using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfServiceConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			ServiceHost host = new ServiceHost(typeof(ChatService));
			host.Open();

			Console.WriteLine("Сервер чата запущен...");
			Console.WriteLine("Для завершения нажмите Enter");
			Console.ReadLine();

			host.Close();
		}
	}
}
