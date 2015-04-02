using UnityEngine;
using System.Collections;

public class MCP : MonoBehaviour
{
	public GameObject pothole;	
	public int potholesCount = 5;
	public int buttonOffsetW = 300;
	public int buttonOffsetH = 10;
	
	public float minSpawnTime = 0f;
	public float maxSpawnTime = 0f;
	
	private static float time = 0f;
	private float spawnRateTimer = 0f;
	
	void Start()
	{
		//reset statics for new game
		ResetTime();
		Nitro.SetIsNitro( false );

		StartCoroutine(SpawnPotholes());
	}
	
	void FixedUpdate()
	{
		time += Time.deltaTime;
		spawnRateTimer += Time.deltaTime;
		
		// reduces the min and max spawn timers making the game more difficult the longer the game goes on
		if( spawnRateTimer >= 10f )
		{
			minSpawnTime -= 0.05f;
			maxSpawnTime -= 0.05f;
			
			if( minSpawnTime <= 0.1f )
			{
				minSpawnTime = 0.1f;
			}
			
			if( maxSpawnTime <= 0.5f )
			{
				maxSpawnTime = 0.5f;
			}
			
			spawnRateTimer = 0f;
		}
	}
	
	IEnumerator SpawnPotholes()
	{
		while(true)
		{
			Instantiate( pothole, new Vector3( Random.Range ( -1.9f, 1.9f), 9.0f, -1.0f ), Quaternion.identity );
			yield return new WaitForSeconds( Random.Range ( minSpawnTime, maxSpawnTime ) );
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
