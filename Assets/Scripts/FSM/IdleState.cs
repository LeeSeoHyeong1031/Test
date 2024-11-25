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
        //Attack
        //if (_player._curWeopon.isAttack == true)
        if (_player.isLeftClick == true)
        {
            Debug.Log("_player.isLeftClick");
            _player.playerStateMachine.TransitionTo(_player.playerStateMachine.attackState);
        }
        else if (_player.isRightClick == true)
        {
            Debug.Log("_player.isRightClick");
            _player.playerStateMachine.TransitionTo(_player.playerStateMachine.attackState);
        }
        //Move
        else if (_player.playerMovement.inputDir.magnitude >= 0.1f)
        {
            _player.playerStateMachine.TransitionTo(_player.playerStateMachine.walkState);
        }
    }

    public void OnExit()
    {

    }

}
