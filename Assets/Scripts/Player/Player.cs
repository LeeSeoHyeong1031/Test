using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private Weopon curweopon;

	private void Update()
	{
		//기본 공격
		if (Input.GetMouseButtonDown(0)) curweopon.CanNormalAttack();

		//스킬 공격
		if (Input.GetMouseButtonDown(1)) curweopon.CanSkillAttack();

	}
}
