using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atoria
{
	[Serializable]
	public class Stat
	{
		public string name;
		public float value;
		public float experience;

		public Stat(string name, float value)
		{
			this.name = name;
			this.value = value;
		}

		public override string ToString()
		{
			return string.Format("[{0}: {1} ({2})]", name, value, experience);
		}
	}
}
