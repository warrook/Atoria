using System.Collections;
using UnityEngine;

namespace Atoria
{
	//TODO: Fuse with Mover
	public class Character : MonoBehaviour
	{
		CharacterData data;

		private void Start()
		{
			data = new CharacterData();
			data.AddStat("strength", 10);
			data.AddStat("constitution", 10);

			Debug.Log(data.GetStat("strength"));
		}
	}
}