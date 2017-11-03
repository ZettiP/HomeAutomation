using System.Net;
using CommonModel;

namespace ServerUI.ServerModel
{
	internal interface IServer
	{
		void AddDevice(Device device);
		void SetPort(IPAddress port);
	}
}
