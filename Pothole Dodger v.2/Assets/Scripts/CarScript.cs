using UnityEngine;
using System.Collections;

public class CarScript : MonoBehaviour
{
	private int movSpd = 10;
	public int hp = 3;
	
	void FixedUpdate ()
	{
		float movHor = Input.GetAxis( "Horizontal" );
		
		rigidbody.velocity = new Vector3( movHor * movSpd, 0.0f, 0.0f );
		
		rigidbody.position = new Vector3 ( Mathf.Clamp( rigidbody.position.x, -1.9f, 1.9f ), transform.position.y, transform.position.z );
	}

	public void Damage( int amount )
	{
		if( hp > 0 )
		{
			hp -= amount;
		}

		if( hp <= 0 )
		{
			LevelManager levelManager = GameObject.Find( "LevelManager" ).GetComponent<LevelManager>();
			levelManager.LoadLevel( "WinScreen" );
		}
	}
}
