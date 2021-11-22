using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atoria
{
	

	public class Keys
	{
		public abstract class KeyHolder
		{
			protected static string AddToList(string name, List<string> list)
			{
				list.Add(name);
				return name;
			}
		}

		public class Skills : KeyHolder
		{
			static Skills Instance = new Skills();

			static List<string> keys = new List<string>();
			public static List<string> All => keys;

			//Body
			public static string Brawn => Add("Brawn");
			public static string Finesse => Add("Finesse");
			public static string Reflex => Add("Reflex");
			public static string Endurance => Add("Endurance");
			//Mind
			public static string Awareness => Add("Awareness");
			public static string Influence => Add("Influence");
			public static string Guile => Add("Guile");
			public static string Insight => Add("Insight");
			//Heart
			public static string Spirit => Add("Spirit");
			public static string Empathy => Add("Empathy");
			public static string Will => Add("Will");
			public static string Discipline => Add("Discipline");
			//Lore
			public static string World => Add("World");
			public static string Nature => Add("Nature");
			public static string Survival => Add("Survival");
			public static string Magic => Add("Magic");

			protected static string Add(string name)
			{
				return AddToList("Skill" + name, keys);
			}
		}

		
	}
}
