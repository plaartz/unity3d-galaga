using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
	private float topBound = 24.0f;
	private float lowerBound = -8.0f;

	void Update() // Destroys projectiles that missed after it leaves view
	{
		if (transform.position.z > topBound)
		{
			Destroy(gameObject);
		}
		else if (transform.position.z < lowerBound)
		{
			Debug.Log("Error! Object behind scene.");
			Destroy(gameObject);
		}
	}
}
