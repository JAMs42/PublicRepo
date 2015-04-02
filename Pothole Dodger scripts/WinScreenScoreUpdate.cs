using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinScreenScoreUpdate : MonoBehaviour
{
	private Text scoreText;

	// Use this for initialization
	void Start ()
	{
		scoreText = this.GetComponent<Text>();
		
		if( scoreText )
		{
			scoreText.text = "YOUR SCORE: " + ( ( int ) ScoreKeeper.GetScore() ).ToString();
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
