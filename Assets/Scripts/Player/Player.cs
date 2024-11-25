using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
	public StateMachine playerStateMachine;
	public PlayerMovement playerMovement;
	public Weapon _curWeopon;
	public bool isLeftMouseClick;
	public bool isRightMouseClick;

	private void Awake()
	{
		Init();
	}

	private void OnEnable()
	{
		PlayerInputManager.Instance.OnDashPressed += playerMovement.Dash;
	}

	private void Start()
	{
		playerStateMachine.Init(playerStateMachine.idleState);
	}

	private void Update()
	{
		playerStateMachine.OnUpdate();

		if (playerStateMachine.CurState != playerStateMachine.attackState)
		{
			playerMovement.Move(PlayerInputManager.Instance.inputMoveDir);
		}

		//기본 공격
		if (Input.GetMouseButtonDown(0)) isLeftMouseClick = true;
		else isLeftMouseClick = false;

		//스킬 공격
		if (Input.GetMouseButtonDown(1)) isRightMouseClick = true;
		else isRightMouseClick = false;

	}

	private void Init()
	{
		playerStateMachine = new StateMachine(this);
		playerMovement = GetComponent<PlayerMovement>();
		_curWeopon = GetComponentInChildren<Weapon>();
	}

	private void OnDestroy()
	{
		PlayerInputManager.Instance.OnDashPressed -= playerMovement.Dash;
	}
}
