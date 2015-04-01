using UnityEngine;
using System.Collections;

public class MCP : MonoBehaviour
{
	public GameObject pothole;	
	public int potholesCount = 5;
	public int buttonOffsetW = 300;
	public int buttonOffsetH = 10;
	
	private static float time = 0f;
	
	void Start()
	{
		//reset statics for new game
		time = 0f;
		Nitro.SetIsNitro( false );

		StartCoroutine(SpawnPotholes());
	}
	
	void FixedUpdate()
	{
		time += Time.deltaTime;
	}
	
	IEnumerator SpawnPotholes()
	{
		while(true)
		{
			Instantiate( pothole, new Vector3( Random.Range ( -1.9f, 1.9f), 9.0f, -1.0f ), Quaternion.identity );
			yield return new WaitForSeconds( Random.Range (1.5f, 3.5f ) );
		}
	}
	
	public static float GetTime()
	{
		return time;
	}
	
	public static void ResetTime()
	{
		time = 0f;
	}
}
