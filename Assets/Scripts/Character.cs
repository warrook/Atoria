using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Atoria
{
	[RequireComponent(typeof(NavMeshAgent))]
	public class Character : MonoBehaviour, ITargetable, IMover, IAttacker
	{
		[SerializeField]
		string characterName;

		CharacterData data;
		float health;

		NavMeshAgent agent;

		ITargetable currentTarget;
		bool doAttack;
		public bool isAttacking => doAttack;
		public float attackCooldown;
		float attack_cd;

		private void Awake()
		{
			agent = GetComponent<NavMeshAgent>();

			data = new CharacterData(Keys.Skills.All.ToArray(), 1);
			data.name = characterName;
			data.HealthMax = 10;
			health = data.HealthMax;
		}

		public void SetMoveTarget(Vector3 pos)
		{
			agent.destination = pos;
			Debug.DrawRay(agent.destination, Vector3.up * 3, Color.red, 5);
		}

		public void StartAttack(ITargetable target)
		{
			currentTarget = target;
			doAttack = true;
			StartCoroutine(AttackSequence());
		}

		public void StopAttack()
		{
			currentTarget = null;
			doAttack = false;
		}

		public void DoAttack(int combo)
		{
			Debug.Log("Hit " + " at " + combo);
			currentTarget.ReceiveAttack(1);
			attack_cd = 0;
		}

		public IEnumerator AttackSequence()
		{
			int combo = 0;
			attack_cd = attackCooldown;
			LogOutput.AddString("attack", attack_cd.ToString());

			while (doAttack)
			{
				LogOutput.UpdateString("attack", attack_cd.ToString());

				if (attack_cd >= attackCooldown)
				{
					DoAttack(combo);
					combo++;
				}

				combo %= 3;

				yield return attack_cd += Time.deltaTime;
			}

			attack_cd = 0;
			LogOutput.RemoveString("attack");
			Debug.Log("Stopping attack");
		}

		public void ReceiveAttack(float damage)
		{
			health -= damage;
			if (health < 0)
				Debug.Log("DEAD!");
		}
	}
}