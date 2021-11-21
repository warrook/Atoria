using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace Atoria
{
	public class CharacterData : ScriptableObject
	{
		[SerializeField]
		private List<Stat> stats = new List<Stat>();

		public Stat GetStat(string name)
		{
			return stats.First(a => a.name == name);
		}

		public List<Stat> AddStat(string name, float value)
		{
			stats.Add(new Stat(name, value));
			return stats;
		}
	}
}