using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaunchProjectile : MonoBehaviour
{
	public GameObject projectilePrefab;

	void Update()
	{
		launchProjectile();
	}

	void launchProjectile() // If Fire button is pressed, launch projectile
	{
		if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.Space))
			Instantiate(projectilePrefab, transform.position, transform.rotation);
	}
}
