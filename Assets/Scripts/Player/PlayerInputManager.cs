using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Context = UnityEngine.InputSystem.InputAction.CallbackContext;

public class PlayerInputManager : MonoBehaviour
{
	private static PlayerInputManager _instance;

	public static PlayerInputManager Instance
	{
		get
		{
			if (_instance == null)
			{
				// 이미 존재하는 인스턴스를 찾아봄.
				_instance = FindObjectOfType<PlayerInputManager>();

				//null이라면 호출
				if (_instance == null)
				{
					SetupIntance();
				}
			}
			return _instance;
		}
	}

	private void Awake()
	{
		RemoveDuplicastes();
	}

	public Vector2 inputMoveDir { get; private set; }
	public event Action OnDashPressed;

	public void OnMove(Context context)
	{
		inputMoveDir = context.ReadValue<Vector2>();
	}

	public void OnDash(Context context)
	{
		if (context.performed)
		{
			OnDashPressed?.Invoke();
		}
	}

	private static void SetupIntance()
	{
		//찾아봄
		_instance = FindObjectOfType<PlayerInputManager>();

		//null이라면
		if (_instance == null)
		{
			GameObject gameObj = new GameObject();
			gameObj.name = typeof(PlayerInputManager).Name;
			_instance = gameObj.AddComponent<PlayerInputManager>();
		}
	}

	private void RemoveDuplicastes()
	{
		if (_instance == null)
		{
			_instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}
}
