using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Atoria
{
	[CreateAssetMenu(menuName = "Game/Dialogue")]
	public class DialogueScriptable : ScriptableObject
	{
		public string Speaker; //The speaker of the text.
		[TextArea(minLines: 1, maxLines: 8)]
		public string Text; //The dialogue spoken.

		/// <summary>
		/// Create a dialogue box with the information here.
		/// </summary>
		/// <returns>Dialogue box containing this object's information.</returns>
		public GameObject CreateDialogue()
		{
			var g = Instantiate(ResourceLoader.DialogueBox);
			g.GetComponent<DialogueBox>().SetInfo(this);
			g.SetActive(false);
			return g;
		}
	}
}
