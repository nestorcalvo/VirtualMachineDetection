using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace VirtualMachineDetection
{
	public class Detection
	{
		public void Run()
		{
			string os_query = "SELECT * FROM Win32_OperatingSystem";
			ManagementObjectSearcher os_searcher = new ManagementObjectSearcher(os_query);
			foreach (ManagementObject info in os_searcher.Get())
			{
				Console.WriteLine(info.Properties["Name"].Value.ToString());
			}

			MessageBox.Show("This computer is in a virtual enviroment");
		}

	}
}