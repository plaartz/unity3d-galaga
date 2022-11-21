﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
	public float speed = 40.0f;
	

	void Update() // Moves projectile
	{
		transform.Translate(Vector3.up * Time.deltaTime * speed);
	}
}
