using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atoria
{
	public interface IAttacker
	{
		void StartAttack(ITargetable target);
		void StopAttack();
		void DoAttack(int combo);
		IEnumerator AttackSequence();
	}
}
