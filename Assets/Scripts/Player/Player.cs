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

        ////�⺻ ����
        //if (Input.GetMouseButtonDown(0)) _curWeopon.CanNormalAttack();

        ////��ų ����
        //if (Input.GetMouseButtonDown(1)) _curWeopon.CanSkillAttack();


        //�⺻ ����
        if (Input.GetMouseButtonDown(0)) isLeftClick = true;
        else isLeftClick = false;

        //��ų ����
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
