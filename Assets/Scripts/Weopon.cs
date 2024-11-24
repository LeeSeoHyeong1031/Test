using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public abstract class Weopon : MonoBehaviour
{
	public float damage;
	public float nomalAttackInterval;
	public float skillAttackInterval;

	public abstract bool CanNormalAttack();
	public abstract bool CanSkillAttack();
}
