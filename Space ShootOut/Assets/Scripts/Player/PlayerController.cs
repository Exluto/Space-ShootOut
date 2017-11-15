using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {
	private float x_thrust = -20.0f;
	private float x_ReThrust = 15.0f;
	private float x_LeThrust = 10.0f;
	private float x_RiThrust = -10.0f;
	private float x_tilt = 1;

	private KeyCode x_ForwardVelocity;
	private KeyCode x_ReverseVelocity;
	private KeyCode x_RightVelocity;
	private KeyCode x_LeftVelocity;
	public Rigidbody x_rb;

	void Start() {
		x_rb = GetComponent<Rigidbody>();
		x_ForwardVelocity = KeyCode.W;
		x_ReverseVelocity = KeyCode.S;
		x_RightVelocity = KeyCode.D;
		x_LeftVelocity = KeyCode.A;
	}
	void Update() {
		if(Input.GetKey(x_ForwardVelocity)) {
			x_rb.AddForce(0, 0, x_thrust, ForceMode.Acceleration);
		}

		if(Input.GetKey(x_ReverseVelocity)) {
			x_rb.AddForce(0, 0, x_ReThrust, ForceMode.Acceleration);
		}

		if(Input.GetKey(x_RightVelocity)) {
			x_rb.AddForce(x_RiThrust, 0, 0, ForceMode.Acceleration);
		}

		if(Input.GetKey(x_LeftVelocity)) {
			x_rb.AddForce(x_LeThrust, 0, 0, ForceMode.Acceleration);
		}

		x_rb.rotation = Quaternion.Euler (0.0f, 0.0f, x_rb.velocity.x * -x_tilt);
		x_rb.drag = 0.8f;
	}
}

//transform.position += Vector3.forward * Time.deltaTime * x_thrust;
//	transform.position -= Vector3.forward * Time.deltaTime * x_RThrust;

// float moveHorizontal =  Input.GetAxis("Horizontal");
		// float moveVertical = Input.GetAxis("Vertical");

		// Vector3 Movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		// x_rb.velocity = Movement * x_speed;
