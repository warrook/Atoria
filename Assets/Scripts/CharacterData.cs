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
		public float HealthMax;
		public float ResourceMax;

		public CharacterData(string[] stats, int initial_value)
		{
			foreach (string s in stats)
			{
				AddStat(s, initial_value);
			}
		}

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