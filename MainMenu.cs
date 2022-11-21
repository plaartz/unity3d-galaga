using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour // Changes scene for button pressed
{
	public void PlayGame() // Loads Game
	{
		SceneManager.LoadScene("My Game");
	}
	public void RestartGame() // Loads Start Menu
	{
		SceneManager.LoadScene("Start Menu");
	}
}
