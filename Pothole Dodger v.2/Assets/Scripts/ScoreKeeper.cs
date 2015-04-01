using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour
{
	private static float score = 0f;
	private Text scoreText;
	
	// Use this for initialization
	void Start ()
	{
		score = 0f;
		
		scoreText = GameObject.FindGameObjectWithTag("canvas").transform.GetChild(0).transform.GetChild(0).GetComponent<Text>();
		
		if ( scoreText )
		{
			scoreText.text = score.ToString();
		}
	}
	
	void Update()
	{
		score += (int) Time.time;
		scoreText.text = ((int)score).ToString();
	}
	
	public static float GetScore()
	{
		return score;
	}
}
