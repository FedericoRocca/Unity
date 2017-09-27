using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeExplosions : MonoBehaviour {

	public float ExplosionForce;
	public float ExplosionRadius;

	void OnCollisionEnter(Collision ObjectCollision)
	{
		
		Collider[] ObjectsCollisions = Physics.OverlapSphere( transform.position, ExplosionRadius);

		for( int i = 0; i < ObjectsCollisions.Length; i++ )
		{
			if( ObjectsCollisions[i].attachedRigidbody == null )
			{
				continue;
			}

			if( ObjectsCollisions[i].gameObject.tag.Equals("Grenade") )
			{
				continue;
			}

			ObjectsCollisions[i].attachedRigidbody.AddExplosionForce( ExplosionForce, transform.position, ExplosionRadius );

		}
		

	}
	
}
