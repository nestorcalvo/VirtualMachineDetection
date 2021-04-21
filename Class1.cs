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
		public bool Run()
		{
			//string os_query = "SELECT * FROM Win32_OperatingSystem";
			//ManagementObjectSearcher os_searcher = new ManagementObjectSearcher(os_query);
			//foreach (ManagementObject info in os_searcher.Get())
			//{
			//	Console.WriteLine(info.Properties["Name"].Value);
			//}
			ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
			//collection to store all management objects
			ManagementObjectCollection moc = mc.GetInstances();
			string name = " ";
			bool vm = false;
			if (moc.Count != 0)
			{
				foreach (ManagementObject mo in mc.GetInstances())
				{
					// display general system information
					Console.WriteLine("\nMachine Model: {0}",
									  mo["Name"].ToString());
					name = mo["Model"].ToString();
				}

			}

			vm = (name.Substring(0, 2) == "VA" ? true : false);
			return vm;
		}

	}
}