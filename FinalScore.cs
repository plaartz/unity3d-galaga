using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
	public TMP_Text finalScore;
	public GameObject finalPoints;
	public AdjustScore pointsAdjust;
	public int final_Points;

	void Update()
	{
		finalScore.text = "Final Score: " + final_Points;
		Debug.Log(final_Points);
	}
	void Awake()
	{
		finalPoints = GameObject.Find("SpawnManager");
		pointsAdjust = finalPoints.GetComponent<AdjustScore>();
		final_Points = pointsAdjust.currentScore;
	}
}
