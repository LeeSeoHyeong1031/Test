using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : IState
{
    private Player player;

    public AttackState(Player player)
    {
        this.player = player;
    }

    public void OnEnter()
    {
        player._curWeopon.CanNormalAttack();
    }

    public void OnUpdate()
    {
        if (player._curWeopon.isAttack == false)
        {
            player.playerStateMachine.TransitionTo(player.playerStateMachine.idleState);
        }
        //Move
        //if (player.playerMovement.inputDir.magnitude >= 0.1f)
        //{
        //    player.playerStateMachine.TransitionTo(player.playerStateMachine.walkState);
        //}
        ////Idle
        //else if (player.playerMovement.inputDir.magnitude < 0.1f)
        //{
        //    player.playerStateMachine.TransitionTo(player.playerStateMachine.idleState);
        //}
    }

    public void OnExit()
    {

    }

}
