using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public StateMachine playerStateMachine;
    public PlayerMovement playerMovement;
    public Weapon _curWeopon;
    public bool isLeftClick;
    public bool isRightClick;

    private void Awake()
    {
        Init();
    }

    private void Start()
    {
        playerStateMachine.Init(playerStateMachine.idleState);
    }

    private void Update()
    {
        playerStateMachine.OnUpdate();

        ////기본 공격
        //if (Input.GetMouseButtonDown(0)) _curWeopon.CanNormalAttack();

        ////스킬 공격
        //if (Input.GetMouseButtonDown(1)) _curWeopon.CanSkillAttack();


        //기본 공격
        if (Input.GetMouseButtonDown(0)) isLeftClick = true;
        else isLeftClick = false;

        //스킬 공격
        if (Input.GetMouseButtonDown(1)) isRightClick = true;
        else isRightClick = false;

    }

    private void Init()
    {
        playerStateMachine = new StateMachine(this);
        playerMovement = GetComponent<PlayerMovement>();
        _curWeopon = GetComponentInChildren<Weapon>();
    }
}
