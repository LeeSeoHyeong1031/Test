using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Context = UnityEngine.InputSystem.InputAction.CallbackContext;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
	public float moveSpeed;
	public float dashSpeed;

	private Rigidbody _rb;

	private void Awake()
	{
		_rb = GetComponent<Rigidbody>();
	}

	public void Move(Vector2 inputDir)
	{
		Vector3 actualMove = new Vector3(inputDir.x, 0, inputDir.y);
		_rb.MovePosition(_rb.position + actualMove * moveSpeed * Time.deltaTime);
	}
	public void Dash()
	{
		Vector3 actualDash = _rb.transform.forward * dashSpeed;
		_rb.AddForce(actualDash, ForceMode.VelocityChange);
	}
}
