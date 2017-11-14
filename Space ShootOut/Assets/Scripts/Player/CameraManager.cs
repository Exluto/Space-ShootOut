using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {
	public Camera x_PlayerCamera;
	public Camera x_RocketCamera;
	private KeyCode x_PlayerView;

/*	public void ShowPlayerView() {
		x_PlayerCamera.enabled = true;
		x_RocketCamera.enabled = false;
	}

	public void ShowRocketView() {
		x_PlayerCamera.enabled = false;
		x_RocketCamera.enabled = false;
	} */

	// Use this for initialization
	void Start () {
		x_PlayerView = KeyCode.R;
		
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(x_PlayerView)) {
			x_PlayerCamera.enabled = false;
			x_RocketCamera.enabled = true;
		}
		
	}
}
