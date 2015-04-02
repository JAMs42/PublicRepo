using UnityEngine;
using System.Collections;

public class PotholeScript : MonoBehaviour
{
	private GameObject childTo;
	private CarScript carScript;
	private int damage = 1;

	void Start()
	{
		// child the potholes to the potholes container for cleanliness in our Hierarchy
		childTo = GameObject.FindGameObjectWithTag("PotholesContainer");
		gameObject.transform.parent = childTo.transform;
	}

	void FixedUpdate()
	{
		if( gameObject.transform.position.y <= -8.0f )
		{
			Destroy( gameObject );
		}
	}

	void OnTriggerEnter( Collider col )
	{
		// if the collider is our player
		if( col.gameObject.GetComponent<CarScript>() != null )
		{
			// deal damage to the player
			col.gameObject.GetComponent<CarScript>().Damage( damage );
		}
	}
}
