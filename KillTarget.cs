using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KillTarget : MonoBehaviour
{
	public int score;
	public GameObject scoreController;
	public AdjustScore ScoreAdjust;

	private void Start()
	{
		score = 1;
	}

	private void Awake() //Finds game component Adjust Score
	{
		scoreController = GameObject.Find("SpawnManager");
		ScoreAdjust = scoreController.GetComponent<AdjustScore>();
	}

	private void OnTriggerEnter(Collider other) // Destroys Projectile and Enemy ship on impact
	{
		ScoreAdjust.increaseScore(score); // Calls AdjustScore Function to increase score
		Destroy(gameObject);
		Destroy(other.gameObject);

	}
}
