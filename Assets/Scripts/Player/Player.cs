using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private Weopon curweopon;

	private void Update()
	{
		//�⺻ ����
		if (Input.GetMouseButtonDown(0)) curweopon.CanNormalAttack();

		//��ų ����
		if (Input.GetMouseButtonDown(1)) curweopon.CanSkillAttack();

	}
}
