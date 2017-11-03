using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float x_Velocity = 20.0f;
	public Rigidbody x_rb;
	public KeyCode x_BowVelocity;
	public KeyCode  x_SternVelocity;

	public KeyCode x_PortVelocity;
	public KeyCode x_StarboordVelocity;
	

	// Use this for initialization
	void Start () {
		x_rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(x_BowVelocity)) {
		

		}
		if(Input.GetKeyDown(x_SternVelocity)) {
		

		}
		if(Input.GetKeyDown(x_StarboordVelocity)) {
			

		}
		if(Input.GetKeyDown(x_PortVelocity)) {
			

		}
		
	}
}
