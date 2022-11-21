using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RestartController : MonoBehaviour
{
	public TMP_Text panelScore;
	public TMP_Text vrScore;
	public TMP_Text panelOver;
	public TMP_Text vrOver;

	public int finalScore;
	public int isHighScore;

	private void Start()
	{
		finalScore = PlayerPrefs.GetInt("Score");
		isHighScore = PlayerPrefs.GetInt("isHighScore"); // iF isHighScore = 1, then there is new high score, else no new high score
		FinalScore();
	}
	void Update() //Restarts to Start Menu when Touchpad is pressed in Game Over Menu
    {
		if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
		{
			SceneManager.LoadScene("Start Menu");
		}
	}
	void FinalScore()
	{
		if (isHighScore == 1)
		{
			panelOver.text = "NEW HIGHSCORE!";
			vrOver.text = "NEW HIGHSCORE";
		}
		else if (isHighScore == 0)
		{
			panelOver.text = "GAME OVER";
			vrOver.text = "GAME OVER";
		}
		panelScore.text = "Final Score: " + finalScore.ToString();
		vrScore.text = "Final Score: " + finalScore.ToString();
	}
}
