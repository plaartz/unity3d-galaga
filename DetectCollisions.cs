using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectCollisions : MonoBehaviour
{
	public int lives;
	public GameObject lifeController;
	public AdjustScore ScoreAdjust;

	void Start()
	{
		lives = 1;
	}

	private void Awake()
	{
		lifeController = GameObject.Find("SpawnManager");
		ScoreAdjust = lifeController.GetComponent<AdjustScore>();
	}

	void OnTriggerEnter(Collider other)
	{
		ScoreAdjust.decreaseLives(lives);
		Destroy(other.gameObject);
	}
}

