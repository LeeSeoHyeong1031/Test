using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
	public float moveSpeed;
	public float dashSpeed;

	private Vector2 inputDir;
	private Rigidbody rb;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		inputDir.x = Input.GetAxis("Horizontal");
		inputDir.y = Input.GetAxis("Vertical");
		inputDir = inputDir.normalized;

		Move();

		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			Dash();
		}
	}

	private void Move()
	{
		Vector3 actualMove = new Vector3(inputDir.x, 0, inputDir.y);
		rb.MovePosition(rb.position + actualMove * moveSpeed * Time.deltaTime);
	}
	private void Dash()
	{
		Vector3 actualDash = rb.transform.forward * dashSpeed;
		rb.AddForce(actualDash, ForceMode.VelocityChange);
	}
}
