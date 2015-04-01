using UnityEngine;
using System.Collections;

public class Config
{
	private static float mapMovSpd = 1f;
	private static int nitroSpd = 2;

	public static float GetMapMovSpd()
	{
		return mapMovSpd;
	}
	
	public static int GetNitroSpd()
	{
		return nitroSpd;
	}
}