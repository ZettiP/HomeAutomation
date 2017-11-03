using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModel
{
	public enum DeviceCategory
	{
		LedStripe,
		Plug,
		ZigBeeLight
	}
    public class Device
    {
	    public String Name;
	    public String ID;

		public DeviceCategory Category;
		public String Location;

		//maybe add room or Category

		//Functions depending on Device
		//https://docs.microsoft.com/en-us/windows/iot-core/learn-about-hardware/pinmappings/pinmappingsrpi
    }
}
