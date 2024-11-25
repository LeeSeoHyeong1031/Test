using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
	private Player _player;

	public IdleState(Player player)
	{
		this._player = player;
	}
	public void OnEnter()
	{
	}

	public void OnUpdate()
	{
		//NormalAttack
		if (_player.isLeftMouseClick == true)
		{
			Debug.Log("_player.isLeftClick");
			_player.playerStateMachine.TransitionTo(_player.playerStateMachine.attackState);
		}
		//SkillAttack
		else if (_player.isRightMouseClick == true)
		{
			Debug.Log("_player.isRightClick");
			_player.playerStateMachine.TransitionTo(_player.playerStateMachine.attackState);
		}
		//Move
		else if (PlayerInputManager.Instance.inputMoveDir.magnitude >= 0.1f)
		{
			_player.playerStateMachine.TransitionTo(_player.playerStateMachine.walkState);
		}
	}

	public void OnExit()
	{

	}

}
