using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class AdjustScore : MonoBehaviour
{
	public int currentScore;
	private int currentLives = 5;
	public int highScore;
	
	public bool gameOver;
	public GameObject[] Enemy;

	public TMP_Text scoreText;
	public TMP_Text lifeText;

    void Start() // Initializing Score & Lives GUI text
    {
		lifeText.text = "Lives: " + currentLives.ToString();
		scoreText.text = "Score: " + currentScore.ToString();
		highScore = PlayerPrefs.GetInt("highScore");
    }

	public void increaseScore(int score) //Function to increase current score when called
	{
		currentScore += score;
		scoreText.text = "Score: " + currentScore.ToString();
	}

	public void decreaseLives(int lives) // Function to decrease lives left when called and when 0 left Game over and change scene
	{
		if (currentLives >= 1)
		{
			currentLives -= lives;
			lifeText.text = "Lives: " + currentLives.ToString();
		}
		else if (currentLives == 0)
		{
			gameOver = true;
			Enemy = GameObject.FindGameObjectsWithTag("Enemy");
			foreach (GameObject i in Enemy)
			{
				Destroy(i);
			}
			if (currentScore > highScore)
			{
				PlayerPrefs.SetInt("highScore", currentScore); // saves score as highscore
				PlayerPrefs.SetInt("isHighScore", 1); // True false across scenes
				PlayerPrefs.Save();
			}
			else
			{
				PlayerPrefs.SetInt("isHighScore", 0); 
				PlayerPrefs.Save();
			}
			PlayerPrefs.SetInt("Score", currentScore); // Sets final score for Game Over Scene to reference
			

			
			
			SceneManager.LoadScene("Game Over");
		}
		else
			Debug.Log("Lives Error");
	}
}
