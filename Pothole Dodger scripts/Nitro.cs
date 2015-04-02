using UnityEngine;
using System.Collections;

public class Nitro
{
	public static bool isNitro = false;
	
	public static bool GetIsNitro()
	{
		return isNitro;
	}
	
	public static void SetIsNitro( bool aug )
	{
		isNitro = aug;
	}
	
	public static float TimedNitro( float time )
	{
		if( time > 5f )
		{
			SetIsNitro( !GetIsNitro() );
			
			MCP.ResetTime();
		}
		
		return time;
	}
}
