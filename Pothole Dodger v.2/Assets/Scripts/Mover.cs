using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{	
	void FixedUpdate ()
	{
		if( Nitro.GetIsNitro().Equals( true ) )
		{			
			Nitro.TimedNitro( MCP.GetTime() );
			
			if( rigidbody == null )
			{
				// for textures
				renderer.material.mainTextureOffset = new Vector2( 0f, Time.time * Config.GetNitroSpd() );
			}
			else if ( rigidbody != null )
			{
				// for sprites
				rigidbody.AddForce( new Vector3( 0f, -Config.GetNitroSpd(), 0f ));
			}
		}
		else if( Nitro.GetIsNitro().Equals( false ) )
		{
			Nitro.TimedNitro( MCP.GetTime() );
			
			if( rigidbody == null )
			{
				// for textures
				renderer.material.mainTextureOffset = new Vector2( 0f, Time.time * Config.GetMapMovSpd() );
			}
			else if ( rigidbody != null )
			{
				// for sprites
				rigidbody.AddForce( new Vector3( 0f, -Config.GetMapMovSpd(), 0f ));
			}
		}
	}
}
