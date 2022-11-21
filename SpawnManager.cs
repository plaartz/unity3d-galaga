using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject[] enemyPrefabs;
	
	private float spawnRangeX = 4.0f;
	private float spawnPosZ = 20.0f;
	private float startDelay = 2.0f;
	private float spawnInterval = 1.5f;

	void Start() //Starts to summon enemies at interval
	{
		InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
	}

	void Update() // If Game Over becomes true, cancels Enemies Summon
	{
		if (GameObject.Find("SpawnManager").GetComponent<AdjustScore>().gameOver == true)
		{
			CancelInvoke();
		}
	}

	void SpawnRandomEnemy()
	{
		Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.75f, spawnPosZ);
		int enemyIndex = Random.Range(0, enemyPrefabs.Length);

		Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

	}
}
