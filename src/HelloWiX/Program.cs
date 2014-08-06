using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HelloWiX
{
	class Program
	{
		static void Main(string[] args)
		{
			ExeConfigurationFileMap map = new ExeConfigurationFileMap();
			map.ExeConfigFilename = Path.Combine(@"C:\ProgramData\developMENTALmadness", Path.GetFileName(Assembly.GetExecutingAssembly().Location) + ".config");

			var config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
			
			var name = config.AppSettings.Settings["FullName"].Value;
			
			Console.WriteLine("Hello, {0}! From Wix", name);
			Console.WriteLine("Press [Enter] to exit...");
			Console.ReadLine();
		}
	}
}
