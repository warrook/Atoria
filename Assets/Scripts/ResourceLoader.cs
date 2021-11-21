using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Atoria
{
	/// <summary>
	/// Contains static references to Resources.
	/// </summary>
	public static class ResourceLoader
	{
		public static GameObject DialogueBox => Resources.Load<GameObject>("UI/DialogueBox");
	}
}
