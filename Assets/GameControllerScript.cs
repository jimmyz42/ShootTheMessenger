using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour {
	public static int score = 0;
	public Text scoreText;
	public Text endMessage;
	public static int lives = 5;
	// Use this for initialization
	void Start () {
		score = 0;
		lives = 5;
		scoreText.text = "Score: " + score.ToString() + ", Lives: " + lives.ToString();
	}
	
	// Update is called once per frame
	void Update () {

		scoreText.text = "Score: " + score.ToString() + ", Lives: " + lives.ToString();
		if (lives <= 0) {
			endMessage.text = "Game Over";
			//System.Threading.Thread.Sleep (3000);
			//Application.Quit ();
			Time.timeScale = 0;
		}
	}
	public static void AddScore (int delta)
	{
		score += delta;
	}
		
	public static void ReduceLife (int delta)
	{
		lives -= delta;
	}
}
