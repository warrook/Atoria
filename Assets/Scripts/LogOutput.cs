using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;

namespace Atoria
{
	public static class LogOutput
	{
		static Dictionary<string, string> stringsForOutput = new Dictionary<string, string>();

		public static string GenerateOutput()
		{
			return string.Join("\n", stringsForOutput.Select(x => string.Format("{0}: {1}", x.Key, x.Value)));
		}

		public static void AddString(string key, string value) => stringsForOutput.Add(key, value);
		public static void UpdateString(string key, string value) => stringsForOutput[key] = value;
		public static void RemoveString(string key) => stringsForOutput.Remove(key);
	}
}
