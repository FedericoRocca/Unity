using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject EnemyProjectile;
	public GameObject WeaponPos;
	private const float ShootTime = 2.0f;
	private float ShootAt;

	// Use this for initialization
	void Start () {
		ShootAt = ShootTime;
	}
	
	// Update is called once per frame
	void Update () {
		
		ShootAt -= Time.deltaTime;

		if( ShootAt <= 0.0f )
		{
			Instantiate( EnemyProjectile, WeaponPos.transform.position, Quaternion.identity );
			ShootAt = ShootTime;
		}

	}
}
