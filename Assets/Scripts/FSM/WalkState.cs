using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class WalkState : IState
{
    public Player player;
    public WalkState(Player player)
    {
        this.player = player;
    }

    public void OnEnter()
    {

    }

    public void OnUpdate()
    {
        //Attack
        if (player.isLeftClick == true)
        {
            player.playerStateMachine.TransitionTo(player.playerStateMachine.attackState);
        }
        //Idle
        else if (player.playerMovement.inputDir.magnitude < 0.1f)
        {
            player.playerStateMachine.TransitionTo(player.playerStateMachine.idleState);
        }
    }

    public void OnExit()
    {

    }

}
