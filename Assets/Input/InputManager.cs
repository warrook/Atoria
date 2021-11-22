using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Cinemachine;
using TMPro;
using System;

namespace Atoria
{
	public class InputManager : MonoBehaviour
	{
		InputState inputState;

		Input input;
		[SerializeField]
		Character character;
		[SerializeField]
		GameObject prefab;

		List<RaycastResult> hits = new List<RaycastResult>();
		EventSystem eventSystem;
		Canvas canvas;
		public TextMeshProUGUI outputGUI;
		public DialogueScriptable dialogue;

		private void Awake()
		{
			input = new Input();
			eventSystem = FindObjectOfType<EventSystem>();
			canvas = GameObject.FindObjectOfType<Canvas>().GetComponent<Canvas>();

			//Temporary
			//Instantiate(prefab, new Vector3(100, 100, 0), prefab.transform.rotation, canvas.transform);
			//ModeUI();
		}

		private void OnEnable()
		{
			input.Enable();
		}

		private void OnDisable()
		{
			input.Disable();
		}

		private void Start()
		{
			input.Main.LeftClick.performed += _ => LeftClick();
			input.Main.LeftClick.canceled += _ => LeftClickUp();
			input.Main.RightClick.performed += _ => RightClick();
		}

		private void Update()
		{
			outputGUI.text = LogOutput.GenerateOutput();
		}

		public void ModeGameplay()
		{
			inputState = InputState.Gameplay;
		}

		public void ModeUI()
		{
			inputState = InputState.UI;
		}

		private void LeftClick()
		{
			Vector2 mousePos = input.Main.MousePosition.ReadValue<Vector2>();
			Debug.Log(mousePos);

			if (inputState == InputState.Gameplay)
			{	
				Ray clickRay = Camera.main.ScreenPointToRay(mousePos);
				if (Physics.Raycast(clickRay, out RaycastHit rayHit))
				{
					// Targeting
					// TODO: Make holding shift click through the target instead of on it
					if (input.Main.Shift.ReadValue<float>() < 1 && rayHit.transform.TryGetComponent<Character>(out Character target))
					{
						Debug.Log(target.name + " " + target.GetInstanceID());
						
						//TODO: Differentiate targets between hostile and friendly, and pick dialogue vs. attack
						var g = dialogue.CreateDialogue();
						g.transform.SetParent(canvas.transform, false);
						g.SetActive(true);
						
						character.StartAttack(target);
					} 
					// Movement
					else if (NavMesh.SamplePosition(rayHit.point, out NavMeshHit navHit, 1f, NavMesh.AllAreas))
					{
						character.SetMoveTarget(navHit.position);
					}
				}
			}
			else if (inputState == InputState.UI)
			{
				var eventData = new PointerEventData(eventSystem) { position = mousePos };
				hits.Clear();

				foreach (var caster in FindObjectsOfType<GraphicRaycaster>())
				{
					caster.Raycast(eventData, hits);
				}

				foreach (var result in hits)
				{
					Debug.Log(result.gameObject.name, result.gameObject);
				}
			}
		}

		private void LeftClickUp()
		{
			if (character.isAttacking)
			{
				character.StopAttack();
			}
		}

		private void RightClick()
		{
			Debug.Log("Ability!");
			//mover.Ability(); or something
		}

		enum InputState
		{
			Gameplay,
			UI
		}
	}
}