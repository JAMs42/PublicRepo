using UnityEngine;
using System.Collections;

public class BadoGuyoController : MonoBehaviour
{
	public GameObject bulletPrefab;
	
	private int damage = 1;
	
	void Start ()
	{
		Shoot();
	}
	
	void Shoot()
	{
		Instantiate( bulletPrefab, new Vector3( transform.position.x, transform.position.x, 0 ), Quaternion.identity );
		
		Invoke( "Shoot", Random.Range( 0.5f, 1.0f ) );
	}
	
	void OnCollisionEnter2D( Collision2D col )
	{
		if( col.gameObject.tag == "Player" )
		{
			Player.Hit( damage );
			
			Destroy( gameObject );
		}
		else if( col.gameObject.tag == "Shot" )
		{
			Destroy( gameObject );	
		}
	}
}
