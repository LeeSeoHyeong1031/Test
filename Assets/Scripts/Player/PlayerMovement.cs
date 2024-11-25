using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float dashSpeed;

    public Vector2 inputDir { get; private set; }
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        inputDir = new Vector2(x, y);
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
    public void Dash()
    {
        Vector3 actualDash = rb.transform.forward * dashSpeed;
        rb.AddForce(actualDash, ForceMode.VelocityChange);
    }
}
