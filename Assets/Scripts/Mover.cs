using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace Atoria {
    [RequireComponent(typeof(NavMeshAgent))]
    public class Mover : MonoBehaviour
    {
        PlayerInput inputComp;
        NavMeshAgent agent;

        public GameObject markerPrefab;
        GameObject activeMarker;

        
        bool doAttack;
        public bool isAttacking => doAttack;
        Target current_target;
        public float attackCooldown;
        float attack_cd;

        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
            inputComp = GetComponent<PlayerInput>();
        }

        public void SetMoveTarget(Vector3 pos)
        {
            agent.destination = pos;
            if (activeMarker == null)
			{
                activeMarker = Instantiate(markerPrefab, pos, markerPrefab.transform.rotation);
			} else
			{
                activeMarker.transform.position = pos;
			}
        }

		private void Update()
		{
			if (doAttack)
			{

                attack_cd += Time.deltaTime;
			}
		}

		public void StartAttack(Target target)
		{
            current_target = target;
			doAttack = true;
            StartCoroutine(AttackSequence());
		}

		public void StopAttack()
		{
            current_target = null;
			doAttack = false;
		}

		void DoAttack(int combo)
		{
            Debug.Log("Hit " + current_target.name + " at " + combo);
            attack_cd = 0;
		}

        IEnumerator AttackSequence()
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
    }
}