using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weopon
{
	public ParticleSystem normalAttackPt;
	public ParticleSystem skillAttackPt;

	private float lastNormalAttackTime;
	private float lastSkillAttackTime;

	private void Start()
	{
		lastNormalAttackTime = Time.time;
		lastSkillAttackTime = Time.time;
	}

	//공격이 가능한지
	public override bool CanNormalAttack()
	{
		if (Time.time >= lastNormalAttackTime)
		{
			lastNormalAttackTime = Time.time;
			NormalAttack();
			return true;
		}

		return false;
	}

	public override bool CanSkillAttack()
	{
		if (Time.time >= lastSkillAttackTime)
		{
			lastSkillAttackTime = Time.time;
			SkillAttack();
			return true;
		}

		return false;
	}

	//기본 공격
	private void NormalAttack()
	{
		normalAttackPt.Play();
	}

	//스킬 공격
	private void SkillAttack()
	{
		skillAttackPt.Play();
	}
}
