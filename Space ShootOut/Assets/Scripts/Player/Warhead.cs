using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warhead : MonoBehaviour {
	public GameObject Rocket_Emitter;
	public GameObject Rocket;
	public float x_RocketForce;
	private KeyCode x_Fire;

	// Use this for initialization
	void Start () {
		x_Fire = KeyCode.Mouse0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(x_Fire)) {
			GameObject Temp_Rocket_Handler;
			Temp_Rocket_Handler = Instantiate(Rocket, Rocket_Emitter.transform.position, Rocket_Emitter.transform.rotation) as GameObject;

			Temp_Rocket_Handler.transform.Rotate(Vector3.left * 90);

			Rigidbody Temp_RigidBody;
			Temp_RigidBody = Temp_Rocket_Handler.GetComponent<Rigidbody>();

			Temp_RigidBody.AddForce(transform.forward * x_RocketForce);

			Destroy(Temp_Rocket_Handler, 10000.0f);
		}
		
	}
}
