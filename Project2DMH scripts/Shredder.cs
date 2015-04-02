using UnityEngine;
using System.Collections;

public class Shredder : MonoBehaviour
{
	void OnTriggerEnter2D( Collider2D col )
	{
		if( col.tag == "Player" )
		{
			Application.LoadLevel( "Game" );
			return;
		}

		if( col.gameObject.transform.parent )
		{
			Destroy ( col.gameObject.transform.parent.gameObject );
		}
		else
		{
			Destroy ( col.gameObject );
		}
	}
}
