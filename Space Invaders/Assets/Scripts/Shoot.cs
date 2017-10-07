using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject EnemyProjectile;
	public GameObject WeaponPos;
	private float ShootTime;
	private float ShootAt;

	// Use this for initialization
	void Start () {
		ShootTime = Random.Range(1.0f, 20.0f);
		ShootAt = ShootTime;
	}
	
	// Update is called once per frame
	void Update () {
		
		ShootAt -= Time.deltaTime;

		if( ShootAt <= 0.0f )
		{
			Instantiate( EnemyProjectile, WeaponPos.transform.position, Quaternion.Euler( 90, 0, 0 ) );
			ShootAt = ShootTime;
		}

	}

    public void AllShoot()
	{
		Instantiate( EnemyProjectile, WeaponPos.transform.position, Quaternion.Euler( 90, 0, 0 ) );
	}


}
