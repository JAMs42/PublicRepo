using UnityEngine;
using System.Collections;

public class PlatformSpawner : MonoBehaviour
{
	public GameObject[] platforms;
	public GameObject enemyPrefab;
	private float enemyOffsetY = 1.5f;

	void Start()
	{
		Spawn();
	}

	void Spawn()
	{
		Instantiate( platforms[ Random.Range(0, platforms.Length ) ], new Vector3( transform.position.x, transform.position.y, 0 ), Quaternion.identity );

		Invoke( "Spawn", Random.Range( 0.5f, 1f ) );
		Invoke( "SpawnEnemy", Random.Range( 2f, 3f ) );
	}

	void SpawnEnemy()
	{
		Instantiate( enemyPrefab, new Vector3( transform.position.x, transform.position.y + enemyOffsetY, 0 ), Quaternion.Euler( new Vector3( 0, -180, 0 ) ) );
	}
}
