using UnityEngine;
using System.Collections;

public class Config
{
	private static float mapMovSpd = 1f;
	private static float nitroSpd = 2f;

	public static float GetMapMovSpd()
	{
		return mapMovSpd;
	}
	
	public static float GetNitroSpd()
	{
		return nitroSpd;
	}
}