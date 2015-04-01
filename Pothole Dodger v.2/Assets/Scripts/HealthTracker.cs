using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthTracker : MonoBehaviour
{
	private Text healthText;
	
	void Start ()
	{
		healthText = GameObject.FindGameObjectWithTag("health").transform.GetChild(0).GetComponent<Text>();
		
		if ( healthText )
		{
			healthText.text = GameObject.FindGameObjectWithTag( "Player" ).GetComponent<CarScript>().hp.ToString();
		}
	}

	void Update ()
	{
		healthText.text = GameObject.FindGameObjectWithTag( "Player" ).GetComponent<CarScript>().hp.ToString();
	}
}
