using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Atoria
{
	/// <summary>
	/// Component added to dialogue boxes, and things that should be set up similarly.
	/// </summary>
	public class DialogueBox : MonoBehaviour
	{
		TextMeshProUGUI speaker;
		TextMeshProUGUI dialogue;

		private void Awake()
		{
			speaker = GetComponentsInChildren<TextMeshProUGUI>().First(x => x.gameObject.name == "Speaker");
			dialogue = GetComponentsInChildren<TextMeshProUGUI>().First(x => x.gameObject.name == "Dialogue");
		}

		public void SetInfo(DialogueScriptable dialogueObj)
		{
			dialogue.text = dialogueObj.Text;
			speaker.text = dialogueObj.Speaker;
		}
	}
}