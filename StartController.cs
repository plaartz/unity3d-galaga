using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartController : MonoBehaviour
{
	public TMP_Text highScoreText;
	public bool resetScore;


	void Start()
	{
		if (resetScore)
		{
			PlayerPrefs.SetInt("highScore", 0);
			PlayerPrefs.Save();
		}
		highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("highScore");
	}
	void Update() // Starts Game Scene When Touchpad is pressed
    {
		if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
		{
			SceneManager.LoadScene("My Game");
		}
    }

	
}
