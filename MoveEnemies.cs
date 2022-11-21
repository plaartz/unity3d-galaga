using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemies : MonoBehaviour
{
	public float speed = 40.0f;

	void Update() // Moves enemies at certain speed
	{
		transform.Translate(Vector3.forward * Time.deltaTime * -speed);
	}
}