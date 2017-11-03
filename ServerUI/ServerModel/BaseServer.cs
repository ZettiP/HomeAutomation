using System;
using System.Collections.Generic;
using System.Net;
using CommonModel;

namespace ServerUI.ServerModel
{
	class BaseServer : IServer
	{
		private List<Device> _devices;
		private IPAddress _port;

		public BaseServer(IPAddress port)
		{
			_devices = new List<Device>();
			SetPort(port);
		}

		/// <summary>
		/// adds a new recognized Device to the DeviceList
		/// </summary>
		public void AddDevice(Device device)
		{
			_devices.Add(device);
		}

		public void SetPort(IPAddress address)
		{
			_port = address;
		}
	}
}
