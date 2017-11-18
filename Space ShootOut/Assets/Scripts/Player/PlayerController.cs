using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : NetworkBehaviour {
	private float x_thrust = -20.0f;
	private float x_ReThrust = 15.0f;
	private float x_LeThrust = 10.0f;
	private float x_RiThrust = -10.0f;
	private float x_tilt = 1.0f;
	// x_rotation not in use, used for x_rb.MoveRotation method at bottom. Vector3 newPos goes up here, other goes in fixed update
//	private float x_rotation = 1.0f;

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
	void FixedUpdate() {
		if(Input.GetKey(x_ForwardVelocity)) {
			x_rb.AddForce(0, 0, x_thrust, ForceMode.Acceleration);
			//transform.Rotate(Vector3.forward);
		}

		if(Input.GetKey(x_ReverseVelocity)) {
			x_rb.AddForce(0, 0, x_ReThrust, ForceMode.Acceleration);
			//transform.Rotate(Vector3.forward);
		}

		if(Input.GetKey(x_RightVelocity)) {
			x_rb.AddForce(x_RiThrust, 0, 0, ForceMode.Acceleration);
		//	transform.Rotate(Vector3.right);
		}

		if(Input.GetKey(x_LeftVelocity)) {
			x_rb.AddForce(x_LeThrust, 0, 0, ForceMode.Acceleration);
			//transform.Rotate(-Vector3.right);
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

/*	if(x_rb.position.x <= 1.0f) {
			Vector3 direction = (newPos - transform.position).normalized;
            x_rb.MovePosition(transform.position + direction * x_rotation * Time.fixedDeltaTime);
		}
		Vector3 newPos = new Vector3(10.0f, 0, 3.0f);
		*/