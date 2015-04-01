using UnityEngine;
using System.Collections;

public class SphereGizmos : MonoBehaviour
{
	public float explosionRadius = 5.0f;

	void OnDrawGizmos()
	{
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere( transform.position, explosionRadius );
	}
	
	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere( transform.position, explosionRadius );
	}
}
