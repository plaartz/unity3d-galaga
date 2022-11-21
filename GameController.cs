using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
	public GameObject projectilePrefab;

	private float RotateSpeed = 40.0f;
	public Quaternion controllerRotation;
	public Quaternion playerRotation;
	public float[] newRotation;

	public Text debugText;
	

	void Update()
	{
		RotatePlayer();
		ConstrainPlayer();
	}

	void RotatePlayer()
	{
		float horizontalInput = Input.GetAxis("Horizontal"); // Horizontal Input from Keyboard
		controllerRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTrackedRemote); // Gets Right Controllers Rotation/Orientation
		Debug.Log(controllerRotation.eulerAngles);


		if (OVRInput.IsControllerConnected(OVRInput.Controller.RTrackedRemote))
			transform.rotation = Quaternion.Slerp(transform.rotation, controllerRotation, Time.deltaTime * 2); // Rotates player to Controllers Rotation
		else
			transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeed * horizontalInput); // Rotates player based on keyboard input
	}

	void ConstrainPlayer() // Keeps player from rotating across the x or z axis
	{
		if (transform.rotation.eulerAngles.x > 0 || transform.rotation.eulerAngles.x < 0)
		{
			transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
		}
		if (transform.rotation.eulerAngles.z > 0 || transform.rotation.z < 0)
			transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
	}
}



