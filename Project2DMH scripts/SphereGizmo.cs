using UnityEngine;
using System.Collections;

public class SphereGizmo : MonoBehaviour
{
	void OnDrawGizmos()
	{
		Gizmos.DrawWireSphere( transform.position, 1f );
	}
}
