using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    private bool TryShoot = false;
    public float Cadency;
    private float TimePassed = 0.0f;
    private bool IsShooting = false;
    public GameObject Weapon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if( Input.GetMouseButton( 0 ) )
        {
            TryShoot = true;
        }

        if( Input.GetMouseButtonUp( 0 ) )
        {
            TryShoot = false;
        }

        TimePassed += Time.deltaTime;

        if( TimePassed >= 0.5f )
        {
            TimePassed = 0.0f;
            IsShooting = false;
        }
        else
        {
            IsShooting = true;
        }

        if( IsShooting )
        {
            Weapon.transform.Rotate(Weapon.transform.rotation.x - 7 * Time.deltaTime, Weapon.transform.rotation.y, Weapon.transform.rotation.z);
        }
        else
        {
            Weapon.transform.Rotate(Weapon.transform.rotation.x * Time.deltaTime, Weapon.transform.rotation.y, Weapon.transform.rotation.z);
        }
	
	}
}
